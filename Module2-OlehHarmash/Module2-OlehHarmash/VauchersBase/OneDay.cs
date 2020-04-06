using System;

namespace Module2_OlehHarmash.VauchersBase
{
    public class OneDay : TravelBase
    {
        public OneDay(string travelName, string travelType, decimal travelPrice, string travelCountry, DateTime travelStart, DateTime travelEnd) 
            : base (travelName, travelType, travelPrice, travelCountry, travelStart, travelEnd)
        {

        }

        public override DateTime TravelEnd
        {
            get => base.TravelEnd;
            set
            { 
                if (TravelStart != TravelEnd)
                {
                    return;
                }
                base.TravelEnd = value;
            }
        }
    }
}
