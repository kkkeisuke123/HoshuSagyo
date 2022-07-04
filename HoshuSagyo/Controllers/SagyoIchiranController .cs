using HoshuSagyo.Data;
using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HoshuSagyo.Controllers
{
    public class SagyoIchiranController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;

        public SagyoIchiranController(HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
        }

        public IActionResult Index()
        {
            // 作業計画を取得し、一覧表示する
            return View(Initialize(_hoshuSagyoDbContext.T_SagyoKeikaku));
        }


        [HttpPost]
        public IActionResult Search([FromForm] SagyoIchiranGamen inputValue)
        {
            // 条件をもとに検索する
            IQueryable<SagyoKeikakuModel> result = _hoshuSagyoDbContext.T_SagyoKeikaku.Select(x => x);

            if (inputValue.Keito != 0)
            {
                result = result.Where(x => x.Keito == inputValue.Keito);
            }
            if (inputValue.Kankatsu != 0)
            {
                result = result.Where(x => x.Kankatsu == inputValue.Kankatsu);
            }
            if (inputValue.SagyoShubetsu != 0)
            {
                result = result.Where(x => x.SagyoShubetsu == inputValue.SagyoShubetsu);
            }
            if (inputValue.SagyoBasho != 0)
            {
                result = result.Where(x => x.SagyoBasho == inputValue.SagyoBasho);
            }
            if (inputValue.SagyoNaiyo is not null)
            {
                result = result.Where(x => x.SagyoNaiyo.Contains(inputValue.SagyoNaiyo));
            }

            // 検索結果を表示する
            return View("Index", Initialize(result));
        }


        private SagyoIchiranGamen Initialize(IQueryable<SagyoKeikakuModel> sagyoKeikakuModels)
        {
            var gamen = new SagyoIchiranGamen();

            // ドロップダウンリストの作成
            gamen.KeitoList = _hoshuSagyoDbContext.M_Keito.Select(x => new Itemlist { Value = x.Keito, Text = x.KeitoName }).ToList();
            gamen.KankatsuList = _hoshuSagyoDbContext.M_Kankatsu.Select(x => new Itemlist { Value = x.Kankatsu, Text = x.KankatsuName }).ToList();
            gamen.SagyoShubetsuList = _hoshuSagyoDbContext.M_SagyoShubetsu.Select(x => new Itemlist { Value = x.SagyoShubetsu, Text = x.SagyoShubetsuName }).ToList();
            gamen.SagyoBashoList = _hoshuSagyoDbContext.M_SagyoBasho.Select(x => new Itemlist { Value = x.SagyoBasho, Text = x.SagyoBashoName }).ToList();

            // 一覧表示する内容の作成
            gamen.SagyoIchiranDisplayContents = new List<SagyoIchiranDisplayContent>();
            foreach (var sagyoKeikaku in sagyoKeikakuModels)
            {
                var content = new SagyoIchiranDisplayContent();

                content.SagyoKaishiBi = sagyoKeikaku.SagyoKaishiNichiji.ToShortDateString();
                content.SagyoNaiyo = sagyoKeikaku.SagyoNaiyo;
                content.JishaSekininshaMei = sagyoKeikaku.JishaSekininshaMei;
                content.JishaSagyoinSu = sagyoKeikaku.JishaSagyoinSu;
                content.KyoryokuGaishaSekininshaMei = sagyoKeikaku.KyoryokuGaishaSekininshaMei;
                content.KyoryokuGaishaSagyoinSu = sagyoKeikaku.KyoryokuGaishaSagyoinSu;
                content.KeitoName = _hoshuSagyoDbContext.M_Keito.FirstOrDefault(x => x.Keito == sagyoKeikaku.Keito).KeitoName;
                content.KankatsuName = _hoshuSagyoDbContext.M_Kankatsu.FirstOrDefault(x => x.Kankatsu == sagyoKeikaku.Kankatsu).KankatsuName;
                content.SagyoShubetsuName = _hoshuSagyoDbContext.M_SagyoShubetsu.FirstOrDefault(x => x.SagyoShubetsu == sagyoKeikaku.SagyoShubetsu).SagyoShubetsuName;
                content.SagyoBashoName = _hoshuSagyoDbContext.M_SagyoBasho.FirstOrDefault(x => x.SagyoBasho == sagyoKeikaku.SagyoBasho).SagyoBashoName;

                gamen.SagyoIchiranDisplayContents.Add(content);
            }

            return gamen;
        }
    }
}
