using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.Layout
{
    public class _DefaultScriptViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
