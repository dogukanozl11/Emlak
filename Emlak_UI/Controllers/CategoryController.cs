using Emlak_UI.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Emlak_UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44382/api/Categories");
            if (responseMessage.IsSuccessStatusCode)//Http den bize gelen yanıtın başarılı olmasıyla bize bir veri döndürür.
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();//Gelen içeriği String formatında oku.
                var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
