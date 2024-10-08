﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateWebUI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            #region Statistic1
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:7232/api/Statistics/ActiveCategoryCount");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.ActiveCategoryCount = jsonData1;
            #endregion

            #region Statistic2
            var client2 = _httpClientFactory.CreateClient();
            var responseMessage2 = await client2.GetAsync("https://localhost:7232/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData2;
            #endregion

            #region Statistic3
            var client3 = _httpClientFactory.CreateClient();
            var responseMessage3 = await client3.GetAsync("https://localhost:7232/api/Statistics/ApartmentCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData3;
            #endregion

            #region Statistic4
            var client4 = _httpClientFactory.CreateClient();
            var responseMessage4 = await client4.GetAsync("https://localhost:7232/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceByRent = jsonData4;
            #endregion

            #region Statistic5
            var client5 = _httpClientFactory.CreateClient();
            var responseMessage5 = await client5.GetAsync("https://localhost:7232/api/Statistics/CityNameByMaxProductCount");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxProductCount = jsonData5;
            #endregion

            #region Statistic6
            var client6 = _httpClientFactory.CreateClient();
            var responseMessage6 = await client6.GetAsync("https://localhost:7232/api/Statistics/DifferentCityCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData6;
            #endregion

            #region Statistic7
            var client7 = _httpClientFactory.CreateClient();
            var responseMessage7 = await client7.GetAsync("https://localhost:7232/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData7;
            #endregion

            #region Statistic8
            var client8 = _httpClientFactory.CreateClient();
            var responseMessage8 = await client8.GetAsync("https://localhost:7232/api/Statistics/LastProductPrice");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData8;
            #endregion

            #region Statistic9
            var client9 = _httpClientFactory.CreateClient();
            var responseMessage9 = await client9.GetAsync("https://localhost:7232/api/Statistics/NewestBuildingYear");
            var jsonData9 = await responseMessage9.Content.ReadAsStringAsync();
            ViewBag.NewestBuildingYear = jsonData9;
            #endregion

            #region Statistic10
            var client10 = _httpClientFactory.CreateClient();
            var responseMessage10 = await client10.GetAsync("https://localhost:7232/api/Statistics/OldestBuildingYear");
            var jsonData10 = await responseMessage10.Content.ReadAsStringAsync();
            ViewBag.OldestBuildingYear = jsonData10;
            #endregion

            #region Statistic11
            var client11 = _httpClientFactory.CreateClient();
            var responseMessage11 = await client11.GetAsync("https://localhost:7232/api/Statistics/PassiveCategoryCount");
            var jsonData11 = await responseMessage11.Content.ReadAsStringAsync();
            ViewBag.PassiveCategoryCount = jsonData11;
            #endregion

            #region Statistic12
            var client12 = _httpClientFactory.CreateClient();
            var responseMessage12 = await client12.GetAsync("https://localhost:7232/api/Statistics/ProductCount");
            var jsonData12 = await responseMessage12.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData12;
            #endregion

            return View();
        }
    }
}
