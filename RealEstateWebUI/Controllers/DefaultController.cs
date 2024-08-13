using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialSearch()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialSearch(string p)
        {
            TempData["word"] = p;
            return RedirectToAction("PropertyListWithSearch","Property");
        }
    }
}
