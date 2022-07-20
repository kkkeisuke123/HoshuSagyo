using HoshuSagyo.Data;
using HoshuSagyo.Enums;
using HoshuSagyo.Models.DisplayModels;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    public class SagyoJissekiController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;

        public SagyoJissekiController(HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
        }

        /// <summary>
        /// 作業実績情報を更新します
        /// </summary>
        /// <param name="inputValue">作業実績画面の入力項目</param>
        /// <returns></returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Update(SagyoJissekiDisplayContent inputValue)
        {
            // 更新処理を実行
            var sagyoJisseki = _hoshuSagyoDbContext.T_SagyoJisseki.FirstOrDefault(x => x.SagyoKeikakuId == inputValue.SagyoKeikakuId);
            if (sagyoJisseki == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業実績が存在しません");
                return Redirect("/SagyoIchiran");
            }

            // 進捗を確認する
            // 作業着手日時と責任者名が入力済の場合
            if (inputValue.SagyoChakushuNichiji != null && inputValue.SagyoChakushuSekininshaMei != null)
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
            sagyoJisseki.SagyoChakushuNichiji = inputValue.SagyoChakushuNichiji;
            sagyoJisseki.SagyoChakushuSekininshaMei = inputValue.SagyoChakushuSekininshaMei ?? string.Empty;
            sagyoJisseki.SagyoKanryoNichiji = inputValue.SagyoKanryoNichiji;
            sagyoJisseki.SagyoKanryoSekininshaMei = inputValue.SagyoKanryoSekininshaMei ?? string.Empty;

            // DB更新
            _hoshuSagyoDbContext.Update(sagyoJisseki);
            _hoshuSagyoDbContext.SaveChanges();

            return Redirect("/SagyoIchiran");
        }
    }
}
