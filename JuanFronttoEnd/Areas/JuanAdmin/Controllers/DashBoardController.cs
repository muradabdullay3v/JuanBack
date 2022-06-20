using Microsoft.AspNetCore.Mvc;

namespace JuanFronttoEnd.Areas.JuanAdmin.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("JuanAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
