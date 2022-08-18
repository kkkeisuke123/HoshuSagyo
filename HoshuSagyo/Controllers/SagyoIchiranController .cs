using HoshuSagyo.Data;
using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using HoshuSagyo.Models.InputModels;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace HoshuSagyo.Controllers
{
    [Authorize]
    public class SagyoIchiranController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        private readonly ILogger<SagyoIchiranController> _logger;

        public SagyoIchiranController(HoshuSagyoDbContext hoshuSagyoDbContext, ILogger<SagyoIchiranController> logger)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
            _logger = logger;
        }

        /// <summary>
        /// 作業一覧画面を表示します
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            // 作業計画を取得し、一覧表示する
            return View(Initialize(_hoshuSagyoDbContext.T_SagyoKeikaku));
        }

        /// <summary>
        /// 作業計画の検索を行います
        /// </summary>
        /// <param name="inputValue">作業一覧画面の入力項目</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Search(SagyoIchiranGamen inputValue)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            // 条件をもとに検索する
            IQueryable<SagyoKeikakuModel> result = _hoshuSagyoDbContext.T_SagyoKeikaku.Select(x => x);

            if (inputValue.Keito is not null)
            {
                result = result.Where(x => x.Keito == inputValue.Keito);
            }
            if (inputValue.Kankatsu is not null)
            {
                result = result.Where(x => x.Kankatsu == inputValue.Kankatsu);
            }
            if (inputValue.SagyoShubetsu is not null)
            {
                result = result.Where(x => x.SagyoShubetsu == inputValue.SagyoShubetsu);
            }
            if (inputValue.SagyoBasho is not null)
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

        /// <summary>
        /// 作業一覧画面に表示する内容を用意します
        /// </summary>
        /// <param name="sagyoKeikakuModels"></param>
        /// <returns></returns>
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

                content.Id = sagyoKeikaku.Id;
                content.SagyoKaishiBi = sagyoKeikaku.SagyoKaishiNichiji.ToShortDateString();
                content.SagyoNaiyo = sagyoKeikaku.SagyoNaiyo;
                content.KeitoName = _hoshuSagyoDbContext.M_Keito.FirstOrDefault(x => x.Keito == sagyoKeikaku.Keito).KeitoName;
                content.KankatsuName = _hoshuSagyoDbContext.M_Kankatsu.FirstOrDefault(x => x.Kankatsu == sagyoKeikaku.Kankatsu).KankatsuName;
                content.SagyoShubetsuName = _hoshuSagyoDbContext.M_SagyoShubetsu.FirstOrDefault(x => x.SagyoShubetsu == sagyoKeikaku.SagyoShubetsu).SagyoShubetsuName;
                content.SagyoBashoName = _hoshuSagyoDbContext.M_SagyoBasho.FirstOrDefault(x => x.SagyoBasho == sagyoKeikaku.SagyoBasho).SagyoBashoName;

                // 作業番号が付与されている場合、進捗を表示する
                if (sagyoKeikaku.SagyoBango != null)
                {
                    var shinchokuRow = _hoshuSagyoDbContext.M_Shinchoku.FirstOrDefault(
                    x => x.Shinchoku ==
                        _hoshuSagyoDbContext.T_SagyoJisseki.FirstOrDefault(x => x.SagyoKeikakuId == sagyoKeikaku.Id).Shinchoku);
                    content.ShinchokuName = shinchokuRow.ShinchokuName;
                    content.ShinchokuColor = shinchokuRow.ShinchokuColor;
                }
                
                gamen.SagyoIchiranDisplayContents.Add(content);
            }

            return gamen;
        }
    }
}
