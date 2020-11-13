using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class HotelReservation
    {
        ///creating a list, it contains hotel names and prices
        List<HotelDetail> hotelList = new List<HotelDetail>();
        SortedDictionary<int, string> sortByPrice = new SortedDictionary<int, string>();
        ArrayList numberOfDays = new ArrayList();
        ///UC-1
        ///AddHotels method is used to add hotels into list
        public void AddHotels()
        {
            ///Addding hotels to list with weekday and weekend rates
            hotelList.Add(new HotelDetail("LakeWood", 110, 90,3));
            hotelList.Add(new HotelDetail("BridgeWood", 150, 50,4));
            hotelList.Add(new HotelDetail("RidgeWood", 220, 150,5));
            Console.WriteLine("Hotels are added into the list");
            ///Displaying added hotels into list
            foreach (var hotels in hotelList)
            {
                Console.WriteLine("Hotel Name" + hotels.hotelName + "  Weekday Rates" + hotels.weekdayRegularRates + "  Weekend rates" + hotels.weekendRegularRates+"  Ratings " + hotels.starRating);
            }
        }
        public void AddingDaysToList(DateTime checkInDate, DateTime checkOutDate)
        {
            while (checkOutDate >= checkInDate)
            {
                numberOfDays.Add(checkInDate.DayOfWeek);
                checkInDate = checkInDate.AddDays(1);
            }
        }
        /// <summary>
        /// calculatingHotelPrices method is used to calculate hotel price
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        public void calculatingHotelPrices(DateTime checkInDate, DateTime checkOutDate)
        {
            if (checkInDate < checkOutDate)
            {
                foreach (var hotels in hotelList)
                {
                    int total = 0;
                    for (int index = 0; index < numberOfDays.Count; index++)
                    {
                        if (numberOfDays[index].ToString().Equals("Saturday") || numberOfDays[index].ToString().Equals("Sunday"))
                        {
                            total = total + hotels.weekendRegularRates;
                        }
                        else
                        {
                            total = total + hotels.weekdayRegularRates;
                        }
                    }
                    Console.WriteLine("Hotel Name : {0} and Total Price : {1}", hotels.hotelName, total);
                    sortByPrice.Add(total, hotels.hotelName);
                }
            }
            else
            {
                Console.WriteLine("enter the dates properly");
            }
        }
        /// <summary>
        /// cheapestHotel method is used to find the cheapest hotel among the present hotels.
        /// </summary>
        /// <param name="checkInDate"></param>
        /// <param name="checkOutDate"></param>
        public void CheapestHotel(DateTime checkInDate, DateTime checkOutDate)
        {
            calculatingHotelPrices(checkInDate, checkOutDate);
            foreach (var hotelPrice in sortByPrice)
            {
                Console.WriteLine("Cheapest Hotel Name : {0} , Total Price : {1}", hotelPrice.Value, hotelPrice.Key);
                break;
            }
        }
    }
}