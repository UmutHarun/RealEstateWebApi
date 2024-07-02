using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
