using HoshuSagyo.Data;
using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    [Authorize]
    public class SagyoKeikakuController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;

        public SagyoKeikakuController(HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
        }

        /// <summary>
        /// 作業計画登録画面を表示します
        /// </summary>
        /// <returns>作業計画登録画面</returns>
        public IActionResult Index()
        {
            return View(Initialize(null));
        }

        /// <summary>
        /// 作業計画編集画面を表示します
        /// </summary>
        /// <param name="id">作業計画ID</param>
        /// <returns>作業計画編集画面</returns>
        public IActionResult Edit(int id)
        {
            return View(Initialize(id));
        }

        /// <summary>
        /// 作業計画参照画面を表示します
        /// </summary>
        /// <param name="id"></param>
        /// <returns>作業計画参照画面</returns>
        public IActionResult Reference(int id)
        {
            return View(Initialize(id));
        }

        /// <summary>
        /// 作業計画削除画面を表示します
        /// </summary>
        /// <param name="id"></param>
        /// <returns>作業計画削除画面</returns>
        public IActionResult Delete(int id)
        {
            return View(Initialize(id));
        }

        /// <summary>
        /// 画面の初期化を行います
        /// </summary>
        /// <param name="id">作業計画ID</param>
        /// <returns>作業計画画面モデル</returns>
        private SagyoKeikakuGamen Initialize(int? id)
        {
            // 作業計画画面のモデル
            var gamen = new SagyoKeikakuGamen();

            // 音声応答設定画面のモデル
            var onseiOto = new OnseiOtoDisplayContent();

            // ドロップダウンリストの項目を用意
            gamen.KeitoList = _hoshuSagyoDbContext.M_Keito.Select(x => new Itemlist { Value = x.Keito, Text = x.KeitoName }).ToList();
            gamen.KankatsuList = _hoshuSagyoDbContext.M_Kankatsu.Select(x => new Itemlist { Value = x.Kankatsu, Text = x.KankatsuName }).ToList();
            gamen.SagyoShubetsuList = _hoshuSagyoDbContext.M_SagyoShubetsu.Select(x => new Itemlist { Value = x.SagyoShubetsu, Text = x.SagyoShubetsuName }).ToList();
            gamen.SagyoBashoList = _hoshuSagyoDbContext.M_SagyoBasho.Select(x => new Itemlist { Value = x.SagyoBasho, Text = x.SagyoBashoName }).ToList();
            onseiOto.OnseiOtoList = _hoshuSagyoDbContext.M_OnseiOto.Select(x => new Itemlist { Value = x.OtoShubetsu, Text = x.OtoShubetsuNaiyo }).ToList();

            // 作業計画IDが指定された場合（編集、参照、削除）、作業計画を取得する
            if (id != null)
            {
                var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == id);
                if (sagyoKeikaku == null)
                {
                    // エラー
                    ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                    return gamen;
                }

                // 作業計画の情報を設定
                gamen.Id = sagyoKeikaku.Id;
                gamen.SagyoKaishiNichiji = sagyoKeikaku.SagyoKaishiNichiji;
                gamen.SagyoShuryoNichiji = sagyoKeikaku.SagyoShuryoNichiji;
                gamen.Keito = sagyoKeikaku.Keito;
                gamen.Kankatsu = sagyoKeikaku.Kankatsu;
                gamen.SagyoShubetsu = sagyoKeikaku.SagyoShubetsu;
                gamen.SagyoBasho = sagyoKeikaku.SagyoBasho;
                gamen.SagyoBango = sagyoKeikaku.SagyoBango;
                gamen.SagyoNaiyo = sagyoKeikaku.SagyoNaiyo;
                gamen.JishaSekininshaMei = sagyoKeikaku.JishaSekininshaMei;
                gamen.JishaSagyoinSu = sagyoKeikaku.JishaSagyoinSu;
                gamen.KyoryokuGaishaSekininshaMei = sagyoKeikaku.KyoryokuGaishaSekininshaMei;
                gamen.KyoryokuGaishaSagyoinSu = sagyoKeikaku.KyoryokuGaishaSagyoinSu;

                // 音声応答の情報を設定
                onseiOto.SagyoKaishiOnseiOtoShubetsu = 
                    _hoshuSagyoDbContext.M_OnseiOtoShosai.FirstOrDefault(
                        x => x.Id == sagyoKeikaku.SagyoKaishiOnseiOtoShosaiId).OtoShubetsu;
                onseiOto.SagyoKaishiOnseiOtoShosaiId = sagyoKeikaku.SagyoKaishiOnseiOtoShosaiId;
                onseiOto.SagyoShuryoOnseiOtoShubetsu =
                    _hoshuSagyoDbContext.M_OnseiOtoShosai.FirstOrDefault(
                        x => x.Id == sagyoKeikaku.SagyoShuryoOnseiOtoShosaiId).OtoShubetsu;
                onseiOto.SagyoShuryoOnseiOtoShosaiId = sagyoKeikaku.SagyoShuryoOnseiOtoShosaiId;

                // 音声応答詳細メッセージプルダウンの項目を設定
                onseiOto.KaishiOnseiOtoShosaiList =
                    _hoshuSagyoDbContext.M_OnseiOtoShosai.Where(
                        x => x.OtoShubetsu == onseiOto.SagyoKaishiOnseiOtoShubetsu).Select(
                            y => new Itemlist { Value = y.Id, Text = y.Message }).ToList();
                onseiOto.ShuryoOnseiOtoShosaiList =
                    _hoshuSagyoDbContext.M_OnseiOtoShosai.Where(
                        x => x.OtoShubetsu == onseiOto.SagyoShuryoOnseiOtoShubetsu).Select(
                            y => new Itemlist { Value = y.Id, Text = y.Message }).ToList();
            }

            gamen.onseiOtoDisplayContent = onseiOto;

            return gamen;
        }


        /// <summary>
        /// 作業計画の登録処理を行います
        /// </summary>
        /// <param name="inputValue">作業計画登録画面の入力項目</param>
        /// <param name="sagyoKaishiOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <param name="sagyoShuryoOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <returns>作業計画完了画面</returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoToroku(SagyoKeikakuGamen inputValue,
            string sagyoKaishiOnseiOtoShosaiId, string sagyoShuryoOnseiOtoShosaiId)
        {
            // 登録処理を実行
            var sagyoKeikakuModel = new SagyoKeikakuModel
            {
                SagyoKaishiNichiji = inputValue.SagyoKaishiNichiji,
                SagyoShuryoNichiji = inputValue.SagyoShuryoNichiji,
                Keito = inputValue.Keito,
                Kankatsu = inputValue.Kankatsu,
                SagyoShubetsu = inputValue.SagyoShubetsu,
                SagyoBasho = inputValue.SagyoBasho,
                SagyoNaiyo = inputValue.SagyoNaiyo,
                JishaSekininshaMei = inputValue.JishaSekininshaMei,
                JishaSagyoinSu = inputValue.JishaSagyoinSu,
                KyoryokuGaishaSekininshaMei = inputValue.KyoryokuGaishaSekininshaMei,
                KyoryokuGaishaSagyoinSu = inputValue.KyoryokuGaishaSagyoinSu,
                SagyoKaishiOnseiOtoShosaiId = int.Parse(sagyoKaishiOnseiOtoShosaiId),
                SagyoShuryoOnseiOtoShosaiId = int.Parse(sagyoShuryoOnseiOtoShosaiId)
            };

            _hoshuSagyoDbContext.Add(sagyoKeikakuModel);
            _hoshuSagyoDbContext.SaveChanges();

            // 完了画面に表示する内容をセット
            ViewData["SyoriNaiyo"] = "登録";

            // 完了画面で「戻る」ボタンを押下したとき、遷移する先の画面をセット
            ViewData["Back"] = "SagyoKeikaku";

            return View("Result", sagyoKeikakuModel);
        }

        /// <summary>
        /// 作業計画の編集処理を行います
        /// </summary>
        /// <param name="inputValue">作業計画編集画面の入力項目</param>
        /// <param name="sagyoKaishiOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <param name="sagyoShuryoOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <returns>作業計画完了画面</returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoEdit(SagyoKeikakuGamen inputValue,
            string sagyoKaishiOnseiOtoShosaiId, string sagyoShuryoOnseiOtoShosaiId)
        {
            // 編集処理を実行
            var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == inputValue.Id);
            if (sagyoKeikaku == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                return Redirect($"/SagyoKeikaku/Edit/{inputValue.Id}");
            }

            sagyoKeikaku.SagyoKaishiNichiji = inputValue.SagyoKaishiNichiji;
            sagyoKeikaku.SagyoShuryoNichiji = inputValue.SagyoShuryoNichiji;
            sagyoKeikaku.Keito = inputValue.Keito;
            sagyoKeikaku.Kankatsu = inputValue.Kankatsu;
            sagyoKeikaku.SagyoShubetsu = inputValue.SagyoShubetsu;
            sagyoKeikaku.SagyoBasho = inputValue.SagyoBasho;
            sagyoKeikaku.SagyoNaiyo = inputValue.SagyoNaiyo;
            sagyoKeikaku.JishaSekininshaMei = inputValue.JishaSekininshaMei;
            sagyoKeikaku.JishaSagyoinSu = inputValue.JishaSagyoinSu;
            sagyoKeikaku.KyoryokuGaishaSekininshaMei = inputValue.KyoryokuGaishaSekininshaMei;
            sagyoKeikaku.KyoryokuGaishaSagyoinSu = inputValue.KyoryokuGaishaSagyoinSu;
            sagyoKeikaku.SagyoKaishiOnseiOtoShosaiId = int.Parse(sagyoKaishiOnseiOtoShosaiId);
            sagyoKeikaku.SagyoShuryoOnseiOtoShosaiId = int.Parse(sagyoShuryoOnseiOtoShosaiId);
            sagyoKeikaku.UpdateDateTime = DateTime.Now;

            _hoshuSagyoDbContext.Update(sagyoKeikaku);
            _hoshuSagyoDbContext.SaveChanges();

            // 完了画面に表示する内容をセット
            ViewData["SyoriNaiyo"] = "編集";

            // 完了画面で「戻る」ボタンを押下したとき、遷移する先の画面をセット
            ViewData["Back"] = "SagyoIchiran";

            return View("Result", sagyoKeikaku);
        }

        /// <summary>
        /// 作業計画の削除処理を行います
        /// </summary>
        /// <param name="id">作業計画ID</param>
        /// <returns>作業計画完了画面</returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoDelete(string id)
        {
            // 削除処理を実行
            var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == int.Parse(id));
            if (sagyoKeikaku == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                return Redirect($"/SagyoKeikaku/Delete/{id}");
            }

            _hoshuSagyoDbContext.Remove(sagyoKeikaku);
            _hoshuSagyoDbContext.SaveChanges();

            // 完了画面に表示する内容をセット
            ViewData["SyoriNaiyo"] = "削除";

            // 完了画面で「戻る」ボタンを押下したとき、遷移する先の画面をセット
            ViewData["Back"] = "SagyoIchiran";

            return View("Result", sagyoKeikaku);
        }
    }
}
