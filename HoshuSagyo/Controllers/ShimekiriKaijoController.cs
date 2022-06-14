using HoshuSagyo.Data;
using HoshuSagyo.Models.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HoshuSagyo.Controllers
{
    [Authorize(Policy = "KeitoPolicy")]
    public class ShimekiriKaijoController : Controller
    {
        private readonly HoshuSagyoDbContext _hoshusagyoDbContext;
        public ShimekiriKaijoController(HoshuSagyoDbContext hoshuSagyoDbContext)
        {
            _hoshusagyoDbContext = hoshuSagyoDbContext;
        }

        public IActionResult Index()
        {
            return View(GetShimekiriModel());
        }

        [HttpPost]
        public IActionResult DoShimekiriKaijo(string shimekiriBi)
        {
            // 締切解除処理を実行
            var shimekiriModel = GetShimekiriModel();
            var shimekiriBiDateTime = DateTime.ParseExact(shimekiriBi, "yyyy/MM/dd", null);
            shimekiriModel.ShimekiriZumiBi = shimekiriBiDateTime;
            _hoshusagyoDbContext.Update(shimekiriModel);
            _hoshusagyoDbContext.SaveChanges();

            return View("Result", shimekiriModel);
        }

        private ShimekiriModel GetShimekiriModel()
        {
            // 締切情報を取得
            int keito = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Keito").Value);
            int kankatsu = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "Kankatsu").Value);

            return _hoshusagyoDbContext.T_Shimekiri.FirstOrDefault(row =>
                    row.Keito == keito && row.Kankatsu == kankatsu);
        }
    }
}
