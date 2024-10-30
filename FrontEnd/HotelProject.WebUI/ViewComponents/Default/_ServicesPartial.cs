using HotelProject.WebApi.Dtos.RoomDto;
using HotelProject.WebApi.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _ServicesPartial : ViewComponent
    {
        public _ServicesPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        private readonly IHttpClientFactory _httpClientFactory;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync("http://localhost:5209/api/Service");
            if (response.IsSuccessStatusCode)
            {
                var JsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(JsonData);
                return View(values);
            }
            return View();
        }
    }
}
