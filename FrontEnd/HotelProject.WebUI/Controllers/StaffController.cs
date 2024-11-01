﻿using HotelProject.WebUI.Models.Staff;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class StaffController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
		public StaffController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();//Bir istemci oluşturduk.
			var response = await client.GetAsync("http://localhost:5209/api/Staff");//İstekte bulunacağımız adresi yazdık.
			if (response.IsSuccessStatusCode)
			{
				var JsonData = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<StaffViewModel>>(JsonData);
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
		public async Task<IActionResult> Add(AddStaffViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("http://localhost:5209/api/Staff", content);
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}


		public async Task<IActionResult> Delete(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"http://localhost:5209/api/Staff/{id}");
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
        public async Task< IActionResult> Update(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.GetAsync($"http://localhost:5209/api/Staff/{id}");
			if(response.IsSuccessStatusCode)
			{
				var JsonData = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateStaffViewModel>(JsonData);
				return View(values);
			}
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Update(UpdateStaffViewModel model)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(model);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var response = await client.PutAsync($"http://localhost:5209/api/Staff", content);
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
