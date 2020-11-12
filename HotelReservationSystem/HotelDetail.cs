using System;
using System.Collections.Generic;
using System.Text;
namespace HotelReservationSystem
{
    public class HotelDetail
    {
        public string hotelName;
        public int weekdayRegularRates;
        public HotelDetail(string hotelName, int weekdayRegularRates)
        {
            this.hotelName = hotelName;
            this.weekdayRegularRates = weekdayRegularRates;
        }
    }
}
