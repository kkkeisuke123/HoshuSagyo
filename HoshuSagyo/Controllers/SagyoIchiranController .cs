using HoshuSagyo.Data;
using HoshuSagyo.Models.DisplayModels;
using HoshuSagyo.Models.InputModels;
using Microsoft.AspNetCore.Mvc;

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
            SagyoIchiranGamen model = new SagyoIchiranGamen();
            model.SagyoIchiranDisplayContents = new List<SagyoIchiranDisplayContent>();

            foreach (var sagyoKeikaku in _hoshuSagyoDbContext.T_SagyoKeikaku)
            {
                var content = new SagyoIchiranDisplayContent();

                // 作業計画情報のデータをそのまま代入する
                content.SagyoKaishiBi = sagyoKeikaku.SagyoKaishiBi;
                content.SagyoNaiyo = sagyoKeikaku.SagyoNaiyo;
                content.JishaSekininshaMei = sagyoKeikaku.JishaSekininshaMei;
                content.JishaSagyoinSu = sagyoKeikaku.JishaSagyoinSu;
                content.KyoryokuGaishaSekininshaMei = sagyoKeikaku.KyoryokuGaishaSekininshaMei;
                content.KyoryokuGaishaSagyoinSu = sagyoKeikaku.KyoryokuGaishaSagyoinSu;

                // マスタを参照して名称を取得し、代入する
                content.KeitoName = _hoshuSagyoDbContext.M_Keito.FirstOrDefault(x => x.Keito == sagyoKeikaku.Keito).KeitoName;
                content.KankatsuName = _hoshuSagyoDbContext.M_Kankatsu.FirstOrDefault(x => x.Kankatsu == sagyoKeikaku.Kankatsu).KankatsuName;
                content.SagyoShubetsuName = _hoshuSagyoDbContext.M_SagyoShubetsu.FirstOrDefault(x => x.SagyoShubetsu == sagyoKeikaku.SagyoShubetsu).SagyoShubetsuName;
                content.SagyoBashoName = _hoshuSagyoDbContext.M_SagyoBasho.FirstOrDefault(x => x.SagyoBasho == sagyoKeikaku.SagyoBasho).SagyoBashoName;

                model.SagyoIchiranDisplayContents.Add(content);
            }
            return View(model);
        }
    }
}
