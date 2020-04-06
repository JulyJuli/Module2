using Module2_OlehHarmash.Interfaces;
using System;

namespace Module2_OlehHarmash.VauchersBase
{
    public class TravelBase : ITravel
    {
        public TravelBase(string travelName, string travelType, decimal travelPrice, string travelCountry, DateTime travelStart, DateTime travelEnd)
        {
            TravelName = travelName;
            TravelType = travelType;
            TravelPrice = travelPrice;
            TravelCountry = travelCountry;
            TravelStart = travelStart;
            TravelEnd = travelEnd;
        }

        private string _travelName = "";
        private string _travelType = "None";
        private decimal _travelPrice = 0;
        private string _travelCountry = "";
        private DateTime _travelStart = DateTime.Now;

        public virtual string TravelName
        {
            get => _travelName;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    return;
                }
                _travelName = value;
            }
        }

        public virtual string TravelType { get; set; }

        public virtual decimal TravelPrice
        {
            get => _travelPrice;
            set
            {
                if (value < 0)
                {
                    return;
                }
                _travelPrice = value;
            }
        }

        public virtual string TravelCountry { get; set; }

        public virtual DateTime TravelStart
        {
            get => _travelStart;
            set
            {
                if (value < _travelStart)
                {
                    return;
                }
                _travelStart = value;
            }
        }
        public virtual DateTime TravelEnd { get; set; }

        public override string ToString()
        {
            return String.Format("Vaucher name: {0}, type: {1}, price: {2}, country: {3}, start: {4}, end: {5}",
                TravelName, TravelType, TravelPrice, TravelCountry, TravelStart.ToShortDateString(), TravelEnd.ToShortDateString());
        }

        
        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
