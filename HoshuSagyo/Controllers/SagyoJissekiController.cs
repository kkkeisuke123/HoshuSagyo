using HoshuSagyo.Data;
using HoshuSagyo.Enums;
using HoshuSagyo.Models.DisplayModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace HoshuSagyo.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class SagyoJissekiController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        private readonly ILogger<SagyoJissekiController> _logger;

        public SagyoJissekiController(HoshuSagyoDbContext hoshuSagyoDbContext, ILogger<SagyoJissekiController> logger)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
            _logger = logger;
        }

        /// <summary>
        /// 作業実績情報を更新します
        /// </summary>
        /// <param name="inputValue">作業実績画面の入力項目</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Update(SagyoJissekiDisplayContent inputValue)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            // 更新処理を実行
            var sagyoJisseki = _hoshuSagyoDbContext.T_SagyoJisseki.FirstOrDefault(x => x.SagyoKeikakuId == inputValue.SagyoKeikakuId);
            if (sagyoJisseki == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業実績が存在しません");
                return Redirect("/SagyoIchiran");
            }

            // 進捗を確認する
            // 中止チェックボックスがチェック済みの場合
            if (inputValue.ChushiFlg == true)
            {
                // 中止
                sagyoJisseki.Shinchoku = (int)Shinchoku.Chushi;
            }
            // 作業着手日時と責任者名が入力済の場合
            else if (inputValue.SagyoChakushuNichiji != null && inputValue.SagyoChakushuSekininshaMei != null)
            {
                // 作業完了日時と責任者名が入力済の場合
                if (inputValue.SagyoKanryoNichiji != null && inputValue.SagyoKanryoSekininshaMei != null)
                {
                    // 完了済
                    sagyoJisseki.Shinchoku = (int)Shinchoku.Kanryozumi;
                }
                else
                {
                    // 着手済
                    sagyoJisseki.Shinchoku = (int)Shinchoku.Chakushuzumi;
                }
            }

            // 画面の入力項目を反映させる
            if (inputValue.ChushiFlg == false)
            {
                sagyoJisseki.SagyoChakushuNichiji = inputValue.SagyoChakushuNichiji;
                sagyoJisseki.SagyoChakushuSekininshaMei = inputValue.SagyoChakushuSekininshaMei ?? string.Empty;
                sagyoJisseki.SagyoKanryoNichiji = inputValue.SagyoKanryoNichiji;
                sagyoJisseki.SagyoKanryoSekininshaMei = inputValue.SagyoKanryoSekininshaMei ?? string.Empty;
            }
            
            // DB更新
            _hoshuSagyoDbContext.Update(sagyoJisseki);
            _hoshuSagyoDbContext.SaveChanges();

            return Redirect("/SagyoIchiran");
        }
    }
}
