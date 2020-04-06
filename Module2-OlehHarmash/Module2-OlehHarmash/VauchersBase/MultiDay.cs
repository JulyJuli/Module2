using Module2_OlehHarmash.Interfaces;
using System;

namespace Module2_OlehHarmash.VauchersBase
{
    public class MultiDay : TravelBase, IHotel
    {
        public MultiDay(string travelName, string travelType, decimal travelPrice, string travelCountry, DateTime travelStart, DateTime travelEnd, string hotelName, int hotelLvl, string hotelFood) 
            : base(travelName, travelType, travelPrice, travelCountry, travelStart, travelEnd)
        {
            HotelName = hotelName;
            HotelLvl = hotelLvl;
            HotelFood = hotelFood;
        }



        private string _hotelName = "NoName";
        private int _hotelLvl = 0;
        private string _hotelFood = "None";

        public virtual string HotelName { get; set; }
        public virtual int HotelLvl
        {
            get => _hotelLvl;
            set
            {
                if (value < 1 || value > 5)
                {
                    return;
                }
                _hotelLvl = value;
            }
        }
        public virtual string HotelFood { get; set; }

        public override string ToString()
        {
            return String.Format("Vaucher name: {0}, type: {1}, price: {2}, country: {3}, start: {4}, end: {5}, hotel: {6}, hotel lvl: {7}, food: {8}",
                TravelName, TravelType, TravelPrice, TravelCountry, TravelStart.ToShortDateString(), TravelEnd.ToShortDateString(), HotelName, HotelLvl, HotelFood);
        }

    }
}
