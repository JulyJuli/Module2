using System;

namespace Module2_OlehHarmash.Interfaces
{
    public interface ITravel
    {
        string TravelName { get; set; }
        string TravelType { get; set; }
        decimal TravelPrice { get; set; }
        string TravelCountry { get; set; }
        DateTime TravelStart { get; set; }
        DateTime TravelEnd { get; set; }
        void PrintInfo();
    }
}
