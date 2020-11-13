using System;
using System.Globalization;
namespace HotelReservationSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hotel Reservation Program\n");
            HotelReservation hotelReservation = new HotelReservation();
            hotelReservation.AddHotels();
            Console.WriteLine("Enter the check-in date informat dd/mm/yyyy");
            string checkIn = Console.ReadLine();
            DateTime checkInDate = DateTime.ParseExact(checkIn, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(checkInDate.ToString("d"));
            Console.WriteLine("Enter the check-out date informat dd/mm/yyyy");
            string checkOut = Console.ReadLine();
            DateTime checkOutDate = DateTime.ParseExact(checkOut,"dd/mm/yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(checkOutDate.ToString("d"));
            Console.WriteLine("Check in day : " + checkInDate.DayOfWeek);
            Console.WriteLine("Checkout date day : " + checkOutDate.DayOfWeek);
            hotelReservation.AddingDaysToList(checkInDate, checkOutDate);
            hotelReservation.CheapestHotel(checkInDate, checkOutDate);
        }
    }
}