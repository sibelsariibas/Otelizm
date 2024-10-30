using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _aboutService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(About p)
        {
            _aboutService.TInsert(p);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            About p = _aboutService.TGetById(id);
            _aboutService.TDelete(p);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(About p)
        {
            _aboutService.TUpdate(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
