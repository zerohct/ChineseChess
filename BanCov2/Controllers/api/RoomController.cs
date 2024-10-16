using Libs.Entity;
using Libs.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BanCov2.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private ChessService chessService;

        public RoomController(ChessService chessService)
        {
            this.chessService = chessService;
        }

        // API lấy danh sách phòng
        [HttpGet("get-room")]
        public ActionResult getRoomList()
        {
            List<Room> roomList = chessService.getRoomList();
            return Ok(new { status = true, message = "", data = roomList });
        }

        // API tạo phòng mới
        [HttpPost("insert-room")]
        public ActionResult insertRoom(Room room)
        {
            Room r = new Room();
            r.Id = Guid.NewGuid();
            r.Name = room.Name;
            chessService.insertRoom(r);
            return Ok(new { status = true, message = "Phòng đã được tạo thành công." });
        }

        // API tham gia phòng
        [HttpPost("join/{id}")]
        public ActionResult JoinRoom(Guid id)
        {
            var room = chessService.joinRoom(id);
            if (room == null)
            {
                return NotFound(new { status = false, message = "Phòng đã đầy hoặc không tồn tại." });
            }
            return Ok(new { status = true, message = "Đã tham gia phòng thành công.", data = room });
        }
    }
}
