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

        public ChessService(ApplicationDbContext dbContext) { 
            _dbContext = dbContext;
            this.roomRepository = new RoomRepository(dbContext);

        }
        public void Save() { 
            _dbContext.SaveChanges();
        }
        public List<Room> getRoomList() { 
            return roomRepository.getRoomList();
        }
        public void insertRoom(Room r) {
            _dbContext.Room.Add(r);
            Save();
        }
    }
}
