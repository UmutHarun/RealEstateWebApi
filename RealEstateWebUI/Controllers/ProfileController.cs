using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
