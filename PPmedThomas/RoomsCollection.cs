using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedThomas
{
    static class RoomsCollection
    {
        public static List<Room> rooms = new List<Room>();
        static RoomsCollection()
        {
            rooms.Add(new Room(101));
            rooms.Add(new Room(102));
            rooms.Add(new Room(103));
            rooms.Add(new Room(104));
            rooms.Add(new Room(105));
            rooms.Add(new Room(106));
            rooms.Add(new Room(107));
            rooms.Add(new Room(108));
            rooms.Add(new Room(109));
        }
        

        static public void CreateRooms()
        {
            
            int floorNumber = 0;
            int roomNumber = 0;
           for (var i = 0; i <= 10; i++)
            {
                floorNumber++;
                for (var y = 0; y <= 20; y++)
                {
                    roomNumber++;
                }
            }

           var room = (floorNumber + 0 + roomNumber);
        }

        static public void ShowRooms()
        {
            foreach (var room in rooms)
            {
                Console.WriteLine(room.RoomId);
            }
        }
    }

}
