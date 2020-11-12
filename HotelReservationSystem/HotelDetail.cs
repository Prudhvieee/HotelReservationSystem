using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class HotelDetail
    {
        public string hotelName;
        public int weekdayRegularRates;
        public int weekendRegularRates;
        public HotelDetail(string hotelName, int weekdayRegularRates,int weekendRegularRates)
        {
            this.hotelName = hotelName;
            this.weekdayRegularRates = weekdayRegularRates;
            this.weekendRegularRates = weekendRegularRates;
        }
    }
}
