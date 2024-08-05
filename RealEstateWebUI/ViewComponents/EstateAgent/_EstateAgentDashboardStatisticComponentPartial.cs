using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.ViewComponents.EstateAgent
{
    public class _EstateAgentDashboardStatisticComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _EstateAgentDashboardStatisticComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region Statistic1
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:7232/api/EstateAgentDashboard/AllProductCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.AllProductCount = jsonData1;
            #endregion

            #region Statistic2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7232/api/EstateAgentDashboard/ProductCountByEmployeeId");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ProductCountByEmployeeId = jsonData2;
            #endregion

            #region Statistic3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7232/api/EstateAgentDashboard/ProductCountByFalseStatus");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ProductCountByFalseStatus = jsonData3;
            #endregion

            #region Statistic4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:7232/api/EstateAgentDashboard/ProductCountByTrueStatus");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.ProductCountByTrueStatus = jsonData4;
            #endregion

            return View();
        }
    }
}
