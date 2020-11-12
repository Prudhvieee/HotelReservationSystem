using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public void AddHotels()
        {
            ///creating a list, it contains hotel names and prices
            List<HotelDetail> hotelList = new List<HotelDetail>();
            ///Addding hotels to list
            hotelList.Add(new HotelDetail("LakeWood", 110));
            hotelList.Add(new HotelDetail("BridgeWood", 160));
            hotelList.Add(new HotelDetail("RidgeWood", 160));
            Console.WriteLine("Hotels are added into the list");
            ///Displaying added hotels into list
            foreach (var item in hotelList)
            {
                Console.WriteLine(item.hotelName+" "+item.weekdayRegularRates);
            }
        }
    }
}