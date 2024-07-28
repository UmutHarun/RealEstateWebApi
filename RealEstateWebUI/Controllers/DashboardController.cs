using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
