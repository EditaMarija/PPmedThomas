using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedThomas
{
    internal class Hotell
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Guest> Guests { get; set; }

        public Hotell(string name) 
        {
            Name = name;
            Employees = new List<Employee>();
            Rooms = new List<Room>();
            Guests = new List<Guest>();
            AddRooms();
        }

        public void Booking()
        {

        }

        public void AddRooms()
        {
            foreach (var rom in RoomsCollection.rooms)
            {
                this.Rooms.Add(rom);
            }
        }
        
    }
}
