using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstateWebUI.Dtos.ServicesDto;
using RealEstateWebUI.Dtos.WhoWeAreDetailDtos;

namespace RealEstateWebUI.ViewComponents.HomePage
{
    public class _DefaultAboutViewComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultAboutViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7232/api/WhoWeAreDetails");
            var responseMessage2 = await client.GetAsync("https://localhost:7232/api/Services");
            if(responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode) 
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);
                ViewBag.title = values.Select(x => x.Title).FirstOrDefault();
                ViewBag.subTitle = values.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.description1 = values.Select(x => x.Description1).FirstOrDefault();
                ViewBag.description2 = values.Select(x => x.Description2).FirstOrDefault();
                ViewBag.services = values2.Select(x => x.ServiceName).ToList();
                return View();
            }
            return View();
        }
    }
}
