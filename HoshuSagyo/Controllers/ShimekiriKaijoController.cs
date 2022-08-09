using HoshuSagyo.Data;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    [Authorize(Policy = "KeitoPolicy")]
    [AutoValidateAntiforgeryToken]
    public class ShimekiriKaijoController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        private readonly IConfiguration _configuration;

        public ShimekiriKaijoController(HoshuSagyoDbContext hoshuSagyoDbContext, IConfiguration configuration)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
            _configuration = configuration;
        }

        /// <summary>
        /// 締切解除画面を表示します
        /// </summary>
        /// <returns>締切解除画面</returns>
        public IActionResult Index()
        {
            // クレームから管轄を取得
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // 締切情報を取得
            var shimekiriModel = GetShimekiriModel(kankatsu);

            // 締切解除画面情報を取得
            return View(GetShimekiriKaijoGamenInfo(shimekiriModel));
        }

        /// <summary>
        /// 締切解除処理を行います
        /// </summary>
        /// <param name="inputValue">締切解除画面の入力項目</param>
        /// <returns>締切解除完了画面</returns>
        [HttpPost]
        public IActionResult DoShimekiriKaijo(ShimekiriGamen inputValue)
        {
            // 設定ファイルから締切可能な期間を取得
            int shimekiriKanoDateRangeInDays = int.Parse(_configuration["ShimekiriKanoDateRangeInDays"]);

            // クレームから管轄を取得
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // 締切情報を取得
            var shimekiriModel = GetShimekiriModel(kankatsu);

            // パラメータをチェック
            if (ModelState.IsValid == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "入力が正しく行われていません");
                return View("Index", GetShimekiriKaijoGamenInfo(shimekiriModel));
            }

            // 過去日が指定されていないことをチェック
            if (IsKakoBi(shimekiriModel.ShimekiriZumiBi, inputValue.NewShimekiriZumiBi) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "新しい締切済日には過去の日付を入力してください");
                return View("Index", GetShimekiriKaijoGamenInfo(shimekiriModel));
            }

            // 締切可能な範囲を超えていないことをチェック
            if (IsKikannai(shimekiriModel.ShimekiriZumiBi, inputValue.NewShimekiriZumiBi, shimekiriKanoDateRangeInDays) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, $"一度に締切可能な期間（{shimekiriKanoDateRangeInDays}日間）を超えています");
                return View("Index", GetShimekiriKaijoGamenInfo(shimekiriModel));
            }

            // 締切解除処理
            shimekiriModel.ShimekiriZumiBi = inputValue.NewShimekiriZumiBi;

            _hoshuSagyoDbContext.Update(shimekiriModel);
            _hoshuSagyoDbContext.SaveChanges();

            return View("Result", shimekiriModel);
        }

        /// <summary>
        /// 締切解除画面の情報を取得します
        /// </summary>
        /// <param name="shimekiriModel">締切情報</param>
        /// <returns>締切解除画面情報</returns>
        private ShimekiriGamen GetShimekiriKaijoGamenInfo(ShimekiriModel shimekiriModel)
        {
            var shimekiriKaijoGamenInfo = new ShimekiriGamen
            {
                OldShimekiriZumiBi = shimekiriModel.ShimekiriZumiBi,
                NewShimekiriZumiBi = shimekiriModel.ShimekiriZumiBi.AddDays(-30)
            };

            return shimekiriKaijoGamenInfo;
        }

        /// <summary>
        /// 締切テーブルからユーザーの系統に紐づくレコードを取得します
        /// </summary>
        /// <param name="kankatsu">管轄コード</param>
        /// <returns>締切モデル</returns>
        private ShimekiriModel GetShimekiriModel(int kankatsu)
        {
            return _hoshuSagyoDbContext.T_Shimekiri.FirstOrDefault(row => row.Kankatsu == kankatsu);
        }

        /// <summary>
        /// 過去日が指定されていることをチェックする
        /// </summary>
        /// <param name="oldDate">現在の締切済日</param>
        /// <param name="newDate">新しい締切済日</param>
        /// <returns>過去日の場合はtrue、それ以外はfalse</returns>
        private bool IsKakoBi(DateTime oldDate, DateTime newDate)
        {
            return oldDate > newDate;
        }

        /// <summary>
        /// 締め切る日付の期間の長さをチェックする
        /// </summary>
        /// <param name="oldDate">現在の締切済日</param>
        /// <param name="newDate">新しい締切済日</param>
        /// <param name="shimekiriKanoDateRangeInDays">締切可能な期間</param>
        /// <returns>期間内の場合はtrue、それ以外はfalse</returns>
        private bool IsKikannai(DateTime oldDate, DateTime newDate, int shimekiriKanoDateRangeInDays)
        {
            // 指定された期間
            int kikan = (oldDate - newDate).Days;

            return kikan <= shimekiriKanoDateRangeInDays;
        }
    }
}
