using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultServicesViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
