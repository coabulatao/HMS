using HotelManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    internal class HMSystem
    {
        private readonly List<Booking> _allBookings = new List<Booking>();
        private readonly List<Hotel> _allHotels = new List<Hotel>();
        private readonly List<User> _allUsers = new List<User>();

        public void AddHotel(Hotel hotel)
        {
            _allHotels.Add(hotel);
        }

        public void RegisterUser(User user)
        {
            _allUsers.Add(user);
        }

        public void DisplayBookingDetails(int reservationNumber)
        {
            Console.WriteLine($"\nDetails of Reservation {reservationNumber}:");
            var booking = _allBookings.FirstOrDefault(b => b.ReservationNumber == reservationNumber);
            if (booking != null)
            {
                Console.WriteLine($"{booking.ReservationNumber} Start Time: {booking.CheckIn}, End Time {booking.CheckOut}, Duration: {booking.Duration}, Total: {booking.Price} ");
            }
            else
            {
                Console.WriteLine("Reservation not found.");
            }
        }

        public Booking CreateBooking(Hotel hotel, HotelRoom room, Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            guest.TotalRoomsCount++;
            var booking = new Booking(checkInDate, checkOutDate, room);
            guest.Booking.Add(booking);
            _allBookings.Add(booking);
            return booking;
        }

        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in _allHotels)
            {
                Console.WriteLine($"{hotel.Name}, {hotel.Address}");
            }
        }
    }
}