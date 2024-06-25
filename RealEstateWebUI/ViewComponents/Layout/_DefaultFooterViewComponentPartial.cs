using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.Layout
{
    public class _DefaultFooterViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
