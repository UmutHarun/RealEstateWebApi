using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.EstateAgent
{
    public class _EstateAgentLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
