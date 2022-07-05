using HoshuSagyo.Data;
using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Mvc;

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
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(Initialize(null));
        }

        /// <summary>
        /// 作業計画編集画面を表示します
        /// </summary>
        /// <param name="id">作業計画ID</param>
        /// <returns></returns>
        public IActionResult Edit(int id)
        {
            return View(Initialize(id));
        }

        private SagyoKeikakuGamen Initialize(int? id)
        {
            var gamen = new SagyoKeikakuGamen();

            // ドロップダウンリストの項目を用意
            gamen.KeitoList = _hoshuSagyoDbContext.M_Keito.Select(x => new Itemlist { Value = x.Keito, Text = x.KeitoName }).ToList();
            gamen.KankatsuList = _hoshuSagyoDbContext.M_Kankatsu.Select(x => new Itemlist { Value = x.Kankatsu, Text = x.KankatsuName }).ToList();
            gamen.SagyoShubetsuList = _hoshuSagyoDbContext.M_SagyoShubetsu.Select(x => new Itemlist { Value = x.SagyoShubetsu, Text = x.SagyoShubetsuName }).ToList();
            gamen.SagyoBashoList = _hoshuSagyoDbContext.M_SagyoBasho.Select(x => new Itemlist { Value = x.SagyoBasho, Text = x.SagyoBashoName }).ToList();

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
            }

            return gamen;
        }

        [HttpPost]
        public IActionResult DoToroku([FromForm] SagyoKeikakuGamen inputValue)
        {
            // 登録処理を実行
            var sagyoKeikakuModel = new SagyoKeikakuModel
            {
                SagyoKaishiNichiji = inputValue.SagyoKaishiBi.Add(inputValue.SagyoKaishiJikan.TimeOfDay),
                SagyoShuryoNichiji = inputValue.SagyoShuryoBi.Add(inputValue.SagyoShuryoJikan.TimeOfDay),
                Keito = inputValue.Keito,
                Kankatsu = inputValue.Kankatsu,
                SagyoShubetsu = inputValue.SagyoShubetsu,
                SagyoBasho = inputValue.SagyoBasho,
                SagyoNaiyo = inputValue.SagyoNaiyo,
                JishaSekininshaMei = inputValue.JishaSekininshaMei,
                JishaSagyoinSu = inputValue.JishaSagyoinSu,
                KyoryokuGaishaSekininshaMei = inputValue.KyoryokuGaishaSekininshaMei,
                KyoryokuGaishaSagyoinSu = inputValue.KyoryokuGaishaSagyoinSu
            };

            _hoshuSagyoDbContext.Add(sagyoKeikakuModel);
            _hoshuSagyoDbContext.SaveChanges();

            // 完了画面に表示する内容をセット
            ViewData["SyoriNaiyo"] = "登録";

            return View("Result", sagyoKeikakuModel);
        }

        [HttpPost]
        public IActionResult DoEdit([FromForm] SagyoKeikakuGamen inputValue)
        {
            // 編集処理を実行
            var sagyoKeikaku = _hoshuSagyoDbContext.T_SagyoKeikaku.FirstOrDefault(x => x.Id == inputValue.Id);
            if (sagyoKeikaku == null)
            {
                // エラー
                ModelState.AddModelError(string.Empty, "作業計画が存在しません");
                //return View("Edit");
                return Redirect($"/SagyoKeikaku/Edit/{inputValue.Id}");
            }

            sagyoKeikaku.SagyoKaishiNichiji = inputValue.SagyoKaishiBi.Add(inputValue.SagyoKaishiJikan.TimeOfDay);
            sagyoKeikaku.SagyoShuryoNichiji = inputValue.SagyoShuryoBi.Add(inputValue.SagyoShuryoJikan.TimeOfDay);
            sagyoKeikaku.Keito = inputValue.Keito;
            sagyoKeikaku.Kankatsu = inputValue.Kankatsu;
            sagyoKeikaku.SagyoShubetsu = inputValue.SagyoShubetsu;
            sagyoKeikaku.SagyoBasho = inputValue.SagyoBasho;
            sagyoKeikaku.SagyoNaiyo = inputValue.SagyoNaiyo;
            sagyoKeikaku.JishaSekininshaMei = inputValue.JishaSekininshaMei;
            sagyoKeikaku.JishaSagyoinSu = inputValue.JishaSagyoinSu;
            sagyoKeikaku.KyoryokuGaishaSekininshaMei = inputValue.KyoryokuGaishaSekininshaMei;
            sagyoKeikaku.KyoryokuGaishaSagyoinSu = inputValue.KyoryokuGaishaSagyoinSu;
            sagyoKeikaku.UpdateDateTime = DateTime.Now;

            _hoshuSagyoDbContext.Update(sagyoKeikaku);
            _hoshuSagyoDbContext.SaveChanges();

            // 完了画面に表示する内容をセット
            ViewData["SyoriNaiyo"] = "編集";

            return View("Result", sagyoKeikaku);
        }
    }
}
