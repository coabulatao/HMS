using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Hotel
    {
        private readonly List<HotelRoom> _rooms;
        public string Name { get; set; }
        public string Address { get; set; }

        public Hotel(string name, string address, List<HotelRoom> rooms)
        {
            Name = name;
            Address = address;
            _rooms = rooms;
        }

        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"\n{Name} - Available Rooms");
            foreach (var room in _rooms.Where(r => !r.IsOccupied))
            {
                Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
            }
        }

        public void DisplayBookedRooms()
        {
            Console.WriteLine($"\n{Name} - Booked Rooms");
            foreach (var room in _rooms.Where(r => r.IsOccupied))
            {
                Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
            }
        }
    }
}