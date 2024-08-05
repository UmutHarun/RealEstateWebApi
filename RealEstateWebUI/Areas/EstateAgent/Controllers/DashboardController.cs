using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Areas.EstateAgent.Controllers
{
    public class DashboardController : Controller
    {
        [Area("EstateAgent")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
