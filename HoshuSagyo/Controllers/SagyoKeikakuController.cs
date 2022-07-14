﻿using HoshuSagyo.Data;
using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HoshuSagyo.Controllers
{
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
        /// <param name="Id">作業計画ID</param>
        /// <returns>作業計画編集画面</returns>
        public IActionResult Edit(int Id)
        {
            return View(Initialize(Id));
        }

        /// <summary>
        /// 作業計画参照画面を表示します
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>作業計画参照画面</returns>
        public IActionResult Reference(int Id)
        {
            return View(Initialize(Id));
        }

        /// <summary>
        /// 作業計画削除画面を表示します
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>作業計画削除画面</returns>
        public IActionResult Delete(int Id)
        {
            return View(Initialize(Id));
        }

        /// <summary>
        /// 画面の初期化を行います
        /// </summary>
        /// <param name="Id">作業計画ID</param>
        /// <returns>作業計画画面モデル</returns>
        private SagyoKeikakuGamen Initialize(int? Id)
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
            onseiOto.OnseiOtoShosaiList = _hoshuSagyoDbContext.M_OnseiOtoShosai.Select(x => new Itemlist { Value = x.Id, Text = x.Message }).ToList();

            // 作業計画IDが指定された場合（編集、参照、削除）、作業計画を取得する
            if (Id != null)
            {
                var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == Id);
                if (sagyoKeikaku == null)
                {
                    // エラー
                    ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                    return gamen;
                }

                gamen.Id = sagyoKeikaku.Id;
                gamen.SagyoKaishiBi = sagyoKeikaku.SagyoKaishiNichiji;
                gamen.SagyoKaishiJikan = sagyoKeikaku.SagyoKaishiNichiji;
                gamen.SagyoShuryoBi = sagyoKeikaku.SagyoShuryoNichiji;
                gamen.SagyoShuryoJikan = sagyoKeikaku.SagyoShuryoNichiji;
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

                onseiOto.SagyoKaishiOnseiOtoShubetsu = 
                    _hoshuSagyoDbContext.M_OnseiOtoShosai.FirstOrDefault(
                        x => x.Id == sagyoKeikaku.SagyoKaishiOnseiOtoShosaiId).OtoShubetsu;
                onseiOto.SagyoKaishiOnseiOtoShosaiId = sagyoKeikaku.SagyoKaishiOnseiOtoShosaiId;
                onseiOto.SagyoShuryoOnseiOtoShubetsu =
                    _hoshuSagyoDbContext.M_OnseiOtoShosai.FirstOrDefault(
                        x => x.Id == sagyoKeikaku.SagyoShuryoOnseiOtoShosaiId).OtoShubetsu;
                onseiOto.SagyoShuryoOnseiOtoShosaiId = sagyoKeikaku.SagyoShuryoOnseiOtoShosaiId;
            }

            gamen.onseiOtoDisplayContent = onseiOto;

            return gamen;
        }


        /// <summary>
        /// 作業計画の登録処理を行います
        /// </summary>
        /// <param name="InputValue">作業計画登録画面の入力項目</param>
        /// <param name="SagyoKaishiOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <param name="SagyoShuryoOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <returns>作業計画完了画面</returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoToroku(SagyoKeikakuGamen InputValue,
            string SagyoKaishiOnseiOtoShosaiId, string SagyoShuryoOnseiOtoShosaiId)
        {
            // 登録処理を実行
            var sagyoKeikakuModel = new SagyoKeikakuModel
            {
                SagyoKaishiNichiji = InputValue.SagyoKaishiBi.Add(InputValue.SagyoKaishiJikan.TimeOfDay),
                SagyoShuryoNichiji = InputValue.SagyoShuryoBi.Add(InputValue.SagyoShuryoJikan.TimeOfDay),
                Keito = InputValue.Keito,
                Kankatsu = InputValue.Kankatsu,
                SagyoShubetsu = InputValue.SagyoShubetsu,
                SagyoBasho = InputValue.SagyoBasho,
                SagyoNaiyo = InputValue.SagyoNaiyo,
                JishaSekininshaMei = InputValue.JishaSekininshaMei,
                JishaSagyoinSu = InputValue.JishaSagyoinSu,
                KyoryokuGaishaSekininshaMei = InputValue.KyoryokuGaishaSekininshaMei,
                KyoryokuGaishaSagyoinSu = InputValue.KyoryokuGaishaSagyoinSu,
                SagyoKaishiOnseiOtoShosaiId = int.Parse(SagyoKaishiOnseiOtoShosaiId),
                SagyoShuryoOnseiOtoShosaiId = int.Parse(SagyoShuryoOnseiOtoShosaiId)
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
        /// <param name="InputValue">作業計画編集画面の入力項目</param>
        /// <param name="SagyoKaishiOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <param name="SagyoShuryoOnseiOtoShosaiId">音声応答詳細メッセージのID</param>
        /// <returns>作業計画完了画面</returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoEdit(SagyoKeikakuGamen InputValue,
            string SagyoKaishiOnseiOtoShosaiId, string SagyoShuryoOnseiOtoShosaiId)
        {
            // 編集処理を実行
            var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == InputValue.Id);
            if (sagyoKeikaku == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                return Redirect($"/SagyoKeikaku/Edit/{InputValue.Id}");
            }

            sagyoKeikaku.SagyoKaishiNichiji = InputValue.SagyoKaishiBi.Add(InputValue.SagyoKaishiJikan.TimeOfDay);
            sagyoKeikaku.SagyoShuryoNichiji = InputValue.SagyoShuryoBi.Add(InputValue.SagyoShuryoJikan.TimeOfDay);
            sagyoKeikaku.Keito = InputValue.Keito;
            sagyoKeikaku.Kankatsu = InputValue.Kankatsu;
            sagyoKeikaku.SagyoShubetsu = InputValue.SagyoShubetsu;
            sagyoKeikaku.SagyoBasho = InputValue.SagyoBasho;
            sagyoKeikaku.SagyoNaiyo = InputValue.SagyoNaiyo;
            sagyoKeikaku.JishaSekininshaMei = InputValue.JishaSekininshaMei;
            sagyoKeikaku.JishaSagyoinSu = InputValue.JishaSagyoinSu;
            sagyoKeikaku.KyoryokuGaishaSekininshaMei = InputValue.KyoryokuGaishaSekininshaMei;
            sagyoKeikaku.KyoryokuGaishaSagyoinSu = InputValue.KyoryokuGaishaSagyoinSu;
            sagyoKeikaku.SagyoKaishiOnseiOtoShosaiId = int.Parse(SagyoKaishiOnseiOtoShosaiId);
            sagyoKeikaku.SagyoShuryoOnseiOtoShosaiId = int.Parse(SagyoShuryoOnseiOtoShosaiId);
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
        /// <param name="Id">作業計画ID</param>
        /// <returns>作業計画完了画面</returns>
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoDelete(string Id)
        {
            // 削除処理を実行
            var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == int.Parse(Id));
            if (sagyoKeikaku == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                return Redirect($"/SagyoKeikaku/Delete/{Id}");
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
