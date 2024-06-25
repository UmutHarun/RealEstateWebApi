using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
