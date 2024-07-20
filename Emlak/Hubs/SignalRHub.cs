﻿using Microsoft.AspNetCore.SignalR;

namespace Emlak_Api.Hubs
{
    public class SignalRHub :Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SignalRHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task SendCategoryCount()
        {
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:44382/api/Statistic/CategoryCount");
            var value1 = await responseMessage1.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCategoryCount", value1);
        }
    }
}
