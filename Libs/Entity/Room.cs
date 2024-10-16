using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entity
{
    public class Room
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Số lượng người chơi tối đa trong phòng (ví dụ trong trò cờ vua, có thể có 2 người chơi tối đa)
        public int MaxPlayers { get; set; } = 2;
        public int CurrentPlayers { get; set; } = 0;

        // Thêm thuộc tính trạng thái phòng (mở, đầy, đóng, v.v.)
        public string Status { get; set; } = "Mở";
    }
}
