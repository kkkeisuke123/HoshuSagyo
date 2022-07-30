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

        /// <summary>
        /// 作業番号付与画面を表示します
        /// </summary>
        /// <returns>作業番号付与画面</returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 作業番号付与処理を行います
        /// </summary>
        /// <param name="inputValue">作業番号付与画面の入力項目</param>
        /// <returns>作業番号付与完了画面</returns>
        [HttpPost]
        public IActionResult DoSagyoBangoFuyo(SagyoBangoGamen inputValue)
        {
            // クレームから管轄を取得
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // 作業計画テーブルから指定された期間のレコードを取得
            var sagyoKeikakuModels = _hoshuSagyoDbContext.T_SagyoKeikaku.Where(x =>
                x.SagyoBango == null &&
                x.Kankatsu == kankatsu &&
                x.SagyoKaishiNichiji.Date >= inputValue.SagyoBiFrom.Date &&
                x.SagyoKaishiNichiji.Date <= inputValue.SagyoBiTo.Date);

            // 指定された期間の年月を取得
            string nengetsu = inputValue.SagyoBiFrom.Year.ToString("d2") + inputValue.SagyoBiFrom.Month.ToString("d2");

            // 作業番号テーブルから指定された年月のレコードを取得
            var sagyoBangoModel = _hoshuSagyoDbContext.T_SagyoBango.FirstOrDefault(
                x => x.Nengetsu == nengetsu && x.Kankatsu == kankatsu);

            // チェック処理
            if (VerifyInputValue(inputValue, kankatsu, sagyoKeikakuModels, sagyoBangoModel) == false)
            {
                // エラー
                return View("Index");
            }

            // 指定された期間（月）の最終番号
            int saishuBango = 0;

            // 指定された範囲（月）で作業番号付与をしたことがある場合
            if (sagyoBangoModel is not null)
            {
                // 最終番号を取得
                saishuBango = sagyoBangoModel.SaishuBango;
            }


            // =============================================
            // 作業番号付与処理
            // =============================================
            
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
        /// 各種チェック処理を行います
        /// </summary>
        /// <param name="inputValue">作業番号付与画面の入力項目</param>
        /// <param name="kankatsu">管轄コード</param>
        /// <param name="sagyoKeikakuModels">作業計画レコード（複数件）</param>
        /// <param name="sagyoBangoModel">作業番号レコード（1件）</param>
        /// <returns>チェック結果</returns>
        private bool VerifyInputValue(SagyoBangoGamen inputValue, int kankatsu,
            IQueryable<SagyoKeikakuModel> sagyoKeikakuModels, SagyoBangoModel sagyoBangoModel)
        {
            // 設定ファイルから最大作業計画件数を取得
            int maxSagyoKeikakuKensu = int.Parse(_configuration["MaxSagyoKeikakuKensu"]);

            // 指定された期間の長さをチェック
            if (IsKikannai(inputValue.SagyoBiFrom, inputValue.SagyoBiTo) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "期間は同じ年月内で指定してください");
                return false;
            }

            // 指定された期間が締切済みであるかチェック
            if (IsShimekiriZumi(inputValue.SagyoBiTo, kankatsu) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "締切済日よりも未来の日時が指定されています");
                return false;
            }

            // 対象データが存在するかチェック
            if (sagyoKeikakuModels.Any() == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "データがありません。期間を変更してください");
                return false;
            }

            // 最大件数を超えていないかチェック
            if (sagyoKeikakuModels.Count() > maxSagyoKeikakuKensu)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画の件数が多すぎます。期間を短くしてください");
                return false;
            }

            // 指定された期間（月）で作業番号付与をしたことがある場合
            if (sagyoBangoModel is not null)
            {
                // 対象月に作業番号を割り当てられる数を超えていないかチェック
                if (sagyoKeikakuModels.Count() > maxSagyoKeikakuKensu - sagyoBangoModel.SaishuBango)
                {
                    // エラー
                    ModelState.AddModelError(string.Empty, "作業計画の件数が多すぎます。期間を短くしてください");
                    return false;
                }
            }

            // チェックOK
            return true;
        }

        /// <summary>
        /// 期間の長さをチェックする
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

        /// <summary>
        /// 指定された日時が締切済であることをチェックする
        /// </summary>
        /// <param name="datetime">日時</param>
        /// <param name="kankatsu">管轄コード</param>
        /// <returns></returns>
        private bool IsShimekiriZumi(DateTime datetime, int kankatsu)
        {
            // 締切済日を取得
            var shimekiri = _hoshuSagyoDbContext.T_Shimekiri.FirstOrDefault(x => x.Kankatsu == kankatsu);

            return datetime <= shimekiri.ShimekiriZumiBi;
        }
    }
}
