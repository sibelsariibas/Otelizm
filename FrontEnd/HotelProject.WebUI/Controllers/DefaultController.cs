﻿using HotelProject.WebApi.Dtos.ServiceDto;
using HotelProject.WebApi.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace HotelProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
		private readonly IHttpClientFactory _httpClientFactory;
		public DefaultController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public IActionResult Index()
        {
            return View();
        }
		[HttpGet]
		public PartialViewResult _SubscribePartial()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> _SubscribePartial( CreateSubscribeDto p)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(p);
			StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("http://localhost:5209/api/Subscribe", content);
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}
