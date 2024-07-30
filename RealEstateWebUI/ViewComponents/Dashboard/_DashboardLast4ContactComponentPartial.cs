using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateWebUI.Dtos.ContactDtos;

namespace RealEstateWebUI.ViewComponents.Dashboard
{
    public class _DashboardLast4ContactComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4ContactComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7232/api/Contacts/Last4Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4ContactResultDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
