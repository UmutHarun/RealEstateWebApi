using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.Layout
{
    public class _DefaultHeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
