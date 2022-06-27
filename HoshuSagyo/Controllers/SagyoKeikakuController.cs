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

        public IActionResult Index()
        {
            return View(Initialize());
        }

        private SagyoKeikakuTorokuGamen Initialize()
        {
            var gamen = new SagyoKeikakuTorokuGamen();

            // ドロップダウンリストの項目を用意
            gamen.KeitoList = _hoshuSagyoDbContext.M_Keito.Select(x => new Itemlist { Value = x.Keito, Text = x.KeitoName }).ToList();
            gamen.KankatsuList = _hoshuSagyoDbContext.M_Kankatsu.Select(x => new Itemlist { Value = x.Kankatsu, Text = x.KankatsuName }).ToList();
            gamen.SagyoShubetsuList = _hoshuSagyoDbContext.M_SagyoShubetsu.Select(x => new Itemlist { Value = x.SagyoShubetsu, Text = x.SagyoShubetsuName }).ToList();
            gamen.SagyoBashoList = _hoshuSagyoDbContext.M_SagyoBasho.Select(x => new Itemlist { Value = x.SagyoBasho, Text = x.SagyoBashoName }).ToList();

            return gamen;
        }

        [HttpPost]
        public IActionResult DoToroku([FromForm] SagyoKeikakuTorokuGamen inputValue)
        {
            // 登録処理を実行
            var sagyoKeikakuModel = new SagyoKeikakuModel
            {
                SagyoKaishiBi = inputValue.SagyoKaishiBi.ToShortDateString(),
                SagyoKaishiJikan = inputValue.SagyoKaishiJikan.ToShortTimeString(),
                SagyoShuryoBi = inputValue.SagyoShuryoBi.ToShortDateString(),
                SagyoShuryoJikan = inputValue.SagyoShuryoJikan.ToShortTimeString(),
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

            return View("Result", sagyoKeikakuModel);
        }
    }
}
