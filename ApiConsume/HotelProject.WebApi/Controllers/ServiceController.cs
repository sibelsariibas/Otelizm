using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;
      public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Service p)
        {
            _serviceService.TInsert(p);
            return Ok();
        }

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
        {
            Service p = _serviceService.TGetById(id);
            _serviceService.TDelete(p);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Service p)
        {
            _serviceService.TUpdate(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _serviceService.TGetById(id);
            return Ok(values);
        }
    }
}
