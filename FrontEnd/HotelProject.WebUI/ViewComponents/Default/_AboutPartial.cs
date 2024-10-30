using HotelProject.WebApi.Dtos.AboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _AboutPartial : ViewComponent
    {
        public _AboutPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        private readonly IHttpClientFactory _httpClientFactory;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5209/api/About");
            if (response.IsSuccessStatusCode)
            {
                var JsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutDto>>(JsonData);
                return View(values);
            }
            return View();  
        }
    }

}
