using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Areas.EstateAgent.Controllers
{
    [Area("EstateAgent")]
    public class LayoutEstateAgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
