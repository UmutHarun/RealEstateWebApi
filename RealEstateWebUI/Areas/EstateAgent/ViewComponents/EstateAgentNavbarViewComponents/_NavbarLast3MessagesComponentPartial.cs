using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using RealEstateWebUI.Dtos.MessageDtos;
using RealEstateWebUI.Services;

namespace RealEstateWebUI.Areas.EstateAgent.ViewComponents.EstateAgentNavbarViewComponents
{
    public class _NavbarLast3MessagesComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILoginService _loginService;

        public _NavbarLast3MessagesComponentPartial(IHttpClientFactory httpClientFactory, ILoginService loginService)
        {
            _httpClientFactory = httpClientFactory;
            _loginService = loginService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var id = _loginService.GetUserId;
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7232/api/Messages?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultInboxMessageDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
