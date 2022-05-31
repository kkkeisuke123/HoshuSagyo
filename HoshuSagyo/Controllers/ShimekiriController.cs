using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    public class ShimekiriController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new ShimekiriModel()
            {
                Kankatsu = 1
            };
            return View(viewModel);
        }
    }
}
