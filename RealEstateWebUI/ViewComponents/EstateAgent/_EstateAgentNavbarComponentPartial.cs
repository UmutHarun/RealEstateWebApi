using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.EstateAgent
{
    public class _EstateAgentNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
