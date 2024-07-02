using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
