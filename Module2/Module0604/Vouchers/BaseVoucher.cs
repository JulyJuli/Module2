using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module0604
{
    abstract public class BaseVoucher
    {        

        public BaseVoucher(double cost, Country country, int hotelClass, Food food)
        {
            Cost = cost;
            Country = country;
            HotelClass = hotelClass;
            Food = food;
        }
        public double Cost { get; set; }
        public Country Country { get; set; }
        public int HotelClass { get; set; }
        public Food Food { get; set; }

        public override string ToString()
        {
            return $"Country: {Country}, HotelClass: {HotelClass}, Food: {Food}, Cost:{Cost}";
        }
    }
}
