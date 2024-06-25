using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.Layout
{
    public class _DefaultNavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
