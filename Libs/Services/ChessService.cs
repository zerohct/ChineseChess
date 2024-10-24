using Libs.Entity;
using Libs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Services
{
    public class ChessService
    {
        private readonly ApplicationDbContext _dbContext;
        private RoomRepository roomRepository;

        public ChessService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.roomRepository = new RoomRepository(dbContext);
        }

        // Phương thức để lưu thay đổi vào cơ sở dữ liệu
        public void Save()
        {
            dbContext.SaveChanges();
        }

        // Phương thức để lấy danh sách phòng
        public List<Room> getRoomList()
        {
            return roomRepository.getRoomList();
        }

        // Phương thức để tạo một phòng mới
        public void insertRoom(Room r)
        {
            dbContext.Room.Add(r);
            Save();
        }

        // Phương thức để tham gia phòng theo ID
        public Room joinRoom(Guid roomId)
        {
            Room room = roomRepository.GetById(roomId);

            if (room != null)
            {
                if (room.Status == "Mở" && room.CurrentPlayers < room.MaxPlayers)
                {
                    room.CurrentPlayers++;

                    // Nếu phòng đã đầy, đánh dấu là đóng
                    if (room.CurrentPlayers >= room.MaxPlayers)
                    {
                        room.Status = "Đóng";
                    }

                    Save();
                    return room;
                }
                else
                {
                    // Trả về null hoặc thông báo nếu phòng đã đầy hoặc đóng
                    return null;
                }
            }
            return null;
        }

    }

}
