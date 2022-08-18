using HoshuSagyo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

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
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// アプリの概要
        /// </summary>
        /// <returns>アプリの概要ページ</returns>
        public IActionResult About()
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            return View();
        }

        /// <summary>
        /// 画面遷移図
        /// </summary>
        /// <returns>画面遷移図ページ</returns>
        public IActionResult TransitionDiagram()
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            return View();
        }

        /// <summary>
        /// 画面の説明
        /// </summary>
        /// <returns>画面の説明ページ</returns>
        public IActionResult ScreenExplanation(int? id)
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

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
        /// 使い方の説明
        /// </summary>
        /// <returns>使い方の紹介ページ</returns>
        public IActionResult Usage()
        {
            _logger.LogInformation($"{MethodBase.GetCurrentMethod().Name} START");

            return View();
        }
    }
}