using HotelProject.WebUI.Models.Staff;
using HotelProject.WebUI.Models.Testimonial;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class TestimonialController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public TestimonialController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.GetAsync("http://localhost:5209/api/Testimonial");
			if (response.IsSuccessStatusCode)
			{
				var JsonData = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<TestimonialViewModel>>(JsonData);
				return View(values);
			}

			return View();
		}

		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Add(AddTestimonialViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("http://localhost:5209/api/Testimonial", content);
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}


		public async Task<IActionResult> Delete(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"http://localhost:5209/api/Testimonial/{id}");
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> Update(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.GetAsync($"http://localhost:5209/api/Testimonial/{id}");
			if (response.IsSuccessStatusCode)
			{
				var JsonData = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateTestimonialViewModel>(JsonData);
				return View(values);
			}
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Update(UpdateTestimonialViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"http://localhost:5209/api/Testimonial", content);
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
