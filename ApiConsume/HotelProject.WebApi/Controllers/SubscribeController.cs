using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {

        private readonly ISubscribeService _subscribeService;
        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Subscribe p)
        {
            _subscribeService.TInsert(p);
            return Ok();
        }

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
        {
            Subscribe p = _subscribeService.TGetById(id);
            _subscribeService.TDelete(p);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Subscribe p)
        {
            _subscribeService.TUpdate(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _subscribeService.TGetById(id);
            return Ok(values);
        }
    }
}
