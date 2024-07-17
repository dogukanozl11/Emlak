using Emlak_UI.Dtos.ProductDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Emlak_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultHomePageProductList(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44382/api/Products/ProductListWithCategory");
            if (responseMessage.IsSuccessStatusCode)//Http den bize gelen yanıtın başarılı olmasıyla bize bir veri döndürür.
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//Gelen içeriği String formatında oku.
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
                
            }
            return View();
        }
    }
}
