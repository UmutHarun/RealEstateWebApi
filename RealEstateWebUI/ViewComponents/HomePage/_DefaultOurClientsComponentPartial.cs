using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultOurClientsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
