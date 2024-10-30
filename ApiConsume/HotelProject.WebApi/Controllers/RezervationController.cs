using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RezervationController : ControllerBase
	{
		private readonly IRezervationService _rezervationService;
		public RezervationController(IRezervationService rezervationService)
		{
			_rezervationService = rezervationService;
		}

		[HttpGet]
		public IActionResult GetList()
		{
			var values = _rezervationService.TGetList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult Add(Rezervation p)
		{
			_rezervationService.TInsert(p);
			return Ok();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			Rezervation p = _rezervationService.TGetById(id);
			_rezervationService.TDelete(p);
			return Ok();
		}

		[HttpPut]
		public IActionResult Update(Rezervation p)
		{
			_rezervationService.TUpdate(p);
			return Ok();
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var values = _rezervationService.TGetById(id);
			return Ok(values);
		}
	}
}
