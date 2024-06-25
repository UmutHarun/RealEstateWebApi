using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
