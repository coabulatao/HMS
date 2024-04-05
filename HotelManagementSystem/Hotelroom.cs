using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class HotelRoom
    {
        public int RoomNumber { get; private set; }
        public RoomStyle Style { get; set; }
        public int Price { get; set; }
        public bool IsOccupied { get; set; }
        public HotelRoom(int roomnumber, RoomStyle style, int price)
        {
            RoomNumber = roomnumber;
            Style = style;
            Price = price;
            IsOccupied = false;
        }
    }
}