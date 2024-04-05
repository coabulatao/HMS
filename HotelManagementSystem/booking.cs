using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class booking
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Duration { get; set; }
        public Booking(DateTime checkin, DateTime checkout, HotelRoom room)
        {
            room.IsOccupied = true;
            Room = room;
            Price = room.Price;
            CheckIn = checkin;
            CheckOut = checkout;
            Duration = checkout.Subtract(checkin).Days;
            ReservationNumber = _reservationNumberSeed++;
        }
    }
}
}
