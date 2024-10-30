using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Testimonial p)
        {
            _testimonialService.TInsert(p);
            return Ok();
        }

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
        {
            Testimonial p = _testimonialService.TGetById(id);
            _testimonialService.TDelete(p);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Testimonial p)
        {
            _testimonialService.TUpdate(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _testimonialService.TGetById(id);
            return Ok(values);
        }
    }
}
