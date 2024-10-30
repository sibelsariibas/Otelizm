using HotelProject.WebApi.Dtos.RezervationDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
	public class RezervationController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public RezervationController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult CreateRezervation()
		{
			return PartialView();
		}
		[HttpPost]
		public async Task<IActionResult> CreateRezervation(CreateRezervationDto model)
		{
			model.Status = "Onay Bekliyor";
			model.City = "İstanbul";
			model.Country = "Türkiye";
			model.Description = string.Empty;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			await client.PostAsync("http://localhost:5209/api/Rezervation", stringContent);
			return RedirectToAction("Index", "Default");
		}
	}
}
