using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService) {
            _roomService=roomService;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]  
        public IActionResult Add(Room p)
        {
            _roomService.TInsert(p);
            return Ok();
        }

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
        {
            Room p = _roomService.TGetById(id);
            _roomService.TDelete(p);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Room p)
        {
            _roomService.TUpdate(p);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var values = _roomService.TGetById(id);
            return Ok(values);
        }
    }
}
