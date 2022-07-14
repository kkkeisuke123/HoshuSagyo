﻿using HoshuSagyo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HoshuSagyo.Controllers
{
    public class AjaxUtilityController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshuSagyoDbContext;

        public AjaxUtilityController(HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _hoshuSagyoDbContext = hoshuSagyoDbContext;
        }

        /// <summary>
        /// 指定された応答種別の音声応答詳細メッセージを取得します
        /// </summary>
        /// <param name="OtoShubetsu">応答種別</param>
        /// <returns>音声応答詳細メッセージのリスト</returns>
        [HttpPost]
        public JsonResult GetOnseiOtoShosai(string OtoShubetsu)
        {
            var shosaiList = _hoshuSagyoDbContext.M_OnseiOtoShosai.Where(x => x.OtoShubetsu == int.Parse(OtoShubetsu));
            return Json(new SelectList(shosaiList, "Id", "Message"));
        }

        /// <summary>
        /// 指定された作業計画の作業実績情報を取得します
        /// </summary>
        /// <param name="SagyoKeikakuId">作業計画ID</param>
        /// <returns>作業実績情報</returns>
        [HttpPost]
        public JsonResult GetSagyoJisseki(string SagyoKeikakuId)
        {
            var sagyoJisseki = _hoshuSagyoDbContext.T_SagyoJisseki.FirstOrDefault(x => x.SagyoKeikakuId == int.Parse(SagyoKeikakuId));
            return Json(sagyoJisseki);
        }
    }
}