using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }   

        [HttpGet]
        public IActionResult GetList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Add(Staff p)
        {
            _staffService.TInsert(p);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           Staff p =  _staffService.TGetById(id);
           _staffService.TDelete(p);   
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Staff p)
        {
            _staffService.TUpdate(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _staffService.TGetById(id);
            return Ok(values);
        }
    }
}
