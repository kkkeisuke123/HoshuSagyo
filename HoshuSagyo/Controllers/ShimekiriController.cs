using HoshuSagyo.Data;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace HoshuSagyo.Controllers
{
    [Authorize(Policy = "KeitoPolicy")]
    [AutoValidateAntiforgeryToken]
    public class ShimekiriController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        private readonly IConfiguration _configuration;
        private readonly ILogger<ShimekiriController> _logger;

        public ShimekiriController(HoshuSagyoDbContext hoshuSagyoDbContext,
            IConfiguration configuration, ILogger<ShimekiriController> logger)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
            _configuration = configuration;
            _logger = logger;
        }

        /// <summary>
        /// 締切画面を表示します
        /// </summary>
        /// <returns>締切画面</returns>
        public IActionResult Index()
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            // クレームから管轄を取得
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            // 締切情報を取得
            var shimekiriModel = GetShimekiriModel(kankatsu);

            // 締切画面情報を取得
            return View(GetShimekiriGamenInfo(shimekiriModel));
        }

        /// <summary>
        /// 締切処理を行います
        /// </summary>
        /// <param name="inputValue">締切画面の入力項目</param>
        /// <returns>締切完了画面</returns>
        [HttpPost]
        public IActionResult DoShimekiri(ShimekiriGamen inputValue)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

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
                return View("Index", GetShimekiriGamenInfo(shimekiriModel));
            }

            // 過去日が指定されていないことをチェック
            if (IsMiraiBi(shimekiriModel.ShimekiriZumiBi, inputValue.NewShimekiriZumiBi) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "新しい締切済日には未来の日付を入力してください");
                return View("Index", GetShimekiriGamenInfo(shimekiriModel));
            }

            // 締切可能な範囲を超えていないことをチェック
            if (IsKikannai(shimekiriModel.ShimekiriZumiBi, inputValue.NewShimekiriZumiBi, shimekiriKanoDateRangeInDays) == false)
            {
                // エラー
                ModelState.AddModelError(string.Empty, $"一度に締切可能な期間（{shimekiriKanoDateRangeInDays}日間）を超えています");
                return View("Index", GetShimekiriGamenInfo(shimekiriModel));
            }

            // 締切処理
            shimekiriModel.ShimekiriZumiBi = inputValue.NewShimekiriZumiBi;

            _hoshuSagyoDbContext.Update(shimekiriModel);
            _hoshuSagyoDbContext.SaveChanges();

            return View("Result", shimekiriModel);
        }

        /// <summary>
        /// 締切画面の情報を取得します
        /// </summary>
        /// <param name="shimekiriModel">締切情報</param>
        /// <returns>締切画面情報</returns>
        private ShimekiriGamen GetShimekiriGamenInfo(ShimekiriModel shimekiriModel)
        {
            var shimekiriGamenInfo = new ShimekiriGamen
            {
                OldShimekiriZumiBi = shimekiriModel.ShimekiriZumiBi,
                NewShimekiriZumiBi = shimekiriModel.ShimekiriZumiBi.AddDays(30)
            };

            return shimekiriGamenInfo;
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
        /// 未来日が指定されていることをチェックする
        /// </summary>
        /// <param name="oldDate">現在の締切済日</param>
        /// <param name="newDate">新しい締切済日</param>
        /// <returns>未来日の場合はtrue、それ以外はfalse</returns>
        private bool IsMiraiBi(DateTime oldDate, DateTime newDate)
        {
            return oldDate < newDate;
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
            int kikan = (newDate - oldDate).Days;

            return kikan <= shimekiriKanoDateRangeInDays;
        }
    }
}
