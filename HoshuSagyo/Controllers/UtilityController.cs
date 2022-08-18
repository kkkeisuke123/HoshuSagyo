using HoshuSagyo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;

namespace HoshuSagyo.Controllers
{
    public class UtilityController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;
        private readonly ILogger<UtilityController> _logger;

        public UtilityController(HoshuSagyoDbContext hoshuSagyoDbContext, ILogger<UtilityController> logger)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
            _logger = logger;
        }

        /// <summary>
        /// 指定された応答種別の音声応答詳細メッセージを取得します
        /// </summary>
        /// <param name="otoShubetsu">応答種別</param>
        /// <returns>音声応答詳細メッセージのリスト</returns>
        [HttpPost]
        public JsonResult GetOnseiOtoShosai(string otoShubetsu)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            var shosaiList = _hoshuSagyoDbContext.M_OnseiOtoShosai.Where(x => x.OtoShubetsu == int.Parse(otoShubetsu));
            return Json(new SelectList(shosaiList, "Id", "Message"));
        }

        /// <summary>
        /// 指定された作業計画の作業実績情報を取得します
        /// </summary>
        /// <param name="sagyoKeikakuId">作業計画ID</param>
        /// <returns>作業実績情報</returns>
        [HttpPost]
        public JsonResult GetSagyoJisseki(string sagyoKeikakuId)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            var sagyoJisseki = _hoshuSagyoDbContext.T_SagyoJisseki.FirstOrDefault(x => x.SagyoKeikakuId == int.Parse(sagyoKeikakuId));
            return Json(sagyoJisseki);
        }
    }
}
