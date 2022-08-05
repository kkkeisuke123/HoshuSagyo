using HoshuSagyo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HoshuSagyo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// アプリの概要
        /// </summary>
        /// <returns>アプリの概要ページ</returns>
        public IActionResult About()
        {
            return View();
        }

        /// <summary>
        /// 画面遷移図
        /// </summary>
        /// <returns>画面遷移図ページ</returns>
        public IActionResult TransitionDiagram()
        {
            return View();
        }

        /// <summary>
        /// 画面の説明
        /// </summary>
        /// <returns>画面の説明ページ</returns>
        public IActionResult ScreenExplanation(int? id)
        {
            if (id is null)
            {
                return View();
            }
            else
            {
                string pageId = ((int)id).ToString("D2");
                return View($"Gamen/{pageId}");
            }
        }

        /// <summary>
        /// 操作方法
        /// </summary>
        /// <returns>操作方法ページ</returns>
        public IActionResult OperationMethod()
        {
            return View();
        }
    }
}