using HoshuSagyo.Data;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    [Authorize(Policy = "KeitoPolicy")]
    [AutoValidateAntiforgeryToken]
    public class ShimekiriController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        public ShimekiriController(HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
        }

        /// <summary>
        /// 締切画面を表示します
        /// </summary>
        /// <returns>締切画面</returns>
        public IActionResult Index()
        {
            return View(GetShimekiriGamenInfo());
        }

        /// <summary>
        /// 締切処理を行います
        /// </summary>
        /// <param name="inputValue">締切画面の入力項目</param>
        /// <returns>締切完了画面</returns>
        [HttpPost]
        public IActionResult DoShimekiri(ShimekiriGamen inputValue)
        {
            // パラメータをチェック
            if (ModelState.IsValid == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "入力が正しく行われていません");
                return View("Index", GetShimekiriGamenInfo());
            }

            // 締切処理
            var shimekiriModel = GetShimekiriModel();
            shimekiriModel.ShimekiriZumiBi = inputValue.NewShimekiriZumiBi;

            _hoshuSagyoDbContext.Update(shimekiriModel);
            _hoshuSagyoDbContext.SaveChanges();

            return View("Result", shimekiriModel);
        }

        /// <summary>
        /// 締切画面の情報を取得します
        /// </summary>
        /// <returns>締切画面情報</returns>
        private ShimekiriGamen GetShimekiriGamenInfo()
        {
            var shimekiriModel = GetShimekiriModel();
            var shimekiriGamenInfo = new ShimekiriGamen
            {
                OldShimekiriZumiBi = shimekiriModel.ShimekiriZumiBi,
                NewShimekiriZumiBi = shimekiriModel.ShimekiriZumiBi.AddMonths(1)
            };

            return shimekiriGamenInfo;
        }

        /// <summary>
        /// 締切テーブルからユーザーの系統に紐づくレコードを取得します
        /// </summary>
        /// <returns>締切モデル</returns>
        private ShimekiriModel GetShimekiriModel()
        {
            // クレームから管轄を取得
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // 締切情報を取得
            return _hoshuSagyoDbContext.T_Shimekiri.FirstOrDefault(row => row.Kankatsu == kankatsu);
        }
    }
}
