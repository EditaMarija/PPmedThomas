using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedThomas
{
    internal class Room
    {
        public int RoomId { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomId, bool isAvailable = false)
        {
            RoomId = roomId;
            IsAvailable = isAvailable;
           
        }
        
    }
}
