using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
