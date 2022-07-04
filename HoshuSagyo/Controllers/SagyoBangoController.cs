using HoshuSagyo.Data;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    [Authorize(Policy = "KeitoPolicy")]
    public class SagyoBangoController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        private readonly IConfiguration _configuration;

        public SagyoBangoController(HoshuSagyoDbContext hoshuSagyoDbContext, IConfiguration configuration)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoSagyoBangoFuyo([FromForm] SagyoBangoGamen inputValue)
        {
            // 指定された期間の長さを確認する
            if (IsKikannai(inputValue.SagyoBiFrom, inputValue.SagyoBiTo) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "期間は同じ年月内で指定してください");
                return View("Index");
            }

            // クレームから系統と管轄を取得
            int keito = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Keito").Value);
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // 指定された期間の作業計画を取得する
            var sagyoKeikakuModels = _hoshuSagyoDbContext.T_SagyoKeikaku.Where(x => 
                x.SagyoBango == null &&
                x.Keito == keito &&
                x.Kankatsu == kankatsu &&
                x.SagyoKaishiNichiji.Date >= inputValue.SagyoBiFrom.Date &&
                x.SagyoKaishiNichiji.Date <= inputValue.SagyoBiTo.Date);

            // 対象データが存在するか確認する
            if (sagyoKeikakuModels.Any() == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "データがありません。期間を変更してください");
                return View("Index");
            }

            // 最大件数を超えていないか確認する
            int maxSagyoKeikakuKensu = int.Parse(_configuration["MaxSagyoKeikakuKensu"]);
            if (sagyoKeikakuModels.Count() > maxSagyoKeikakuKensu)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画の件数が多すぎます。期間を短くしてください");
                return View("Index");
            }

            // 対象月に作業番号を割り当てられる数を超えていないか確認する
            string nengetsu = inputValue.SagyoBiFrom.Year.ToString("d2") + inputValue.SagyoBiFrom.Month.ToString("d2");
            var sagyoBangoModel = _hoshuSagyoDbContext.T_SagyoBango.FirstOrDefault(x => x.Nengetsu == nengetsu);

            // 後続の処理で、指定された範囲（月）の最終番号を格納する
            int saishuBango = 0;

            // 指定された範囲（月）で作業番号付与をしたことがある場合
            if (sagyoBangoModel != null)
            {
                saishuBango = sagyoBangoModel.SaishuBango;

                if (sagyoKeikakuModels.Count() > maxSagyoKeikakuKensu - saishuBango)
                {
                    // エラー
                    ModelState.AddModelError(string.Empty, "作業計画の件数が多すぎます。期間を短くしてください");
                    return View("Index");
                }
            }

            // 作業番号付与処理を実行
            // 作業計画情報の更新
            foreach (var model in sagyoKeikakuModels.ToList())
            {
                saishuBango++;
                model.SagyoBango = saishuBango;
                _hoshuSagyoDbContext.Update(model);
                _hoshuSagyoDbContext.SaveChanges();
            }

            // 作業番号情報の更新
            // 指定された範囲（月）での作業番号付与が初めての場合
            if (sagyoBangoModel == null)
            {
                DateTime now = DateTime.Now;
                sagyoBangoModel = new SagyoBangoModel
                {
                    Nengetsu = nengetsu,
                    Keito = keito,
                    Kankatsu = kankatsu,
                    SaishuBango = saishuBango,
                    RegisterDateTime = now,
                    UpdateDateTime = now
                };
                _hoshuSagyoDbContext.Add(sagyoBangoModel);
            }
            else
            {
                sagyoBangoModel.SaishuBango = saishuBango;
                _hoshuSagyoDbContext.Update(sagyoBangoModel);
            }
            
            _hoshuSagyoDbContext.SaveChanges();

            return View("Result", sagyoBangoModel);
        }

        /// <summary>
        /// 期間の長さを確認する
        /// </summary>
        /// <param name="from">日付（から）</param>
        /// <param name="to">日付（まで）</param>
        /// <returns>期間内に収まっていればtrue、それ以外はfalse</returns>
        private bool IsKikannai(DateTime from, DateTime to)
        {
            // 日付（から）～日付（まで）が同じ年月であるか確認
            string fromYM = from.Year.ToString() + from.Month.ToString();
            string toYM = to.Year.ToString() + to.Month.ToString();

            return fromYM == toYM;
        }

    }
}
