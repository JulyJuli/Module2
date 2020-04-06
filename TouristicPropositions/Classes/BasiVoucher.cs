using System;
using TouristicPropositions.Interface;

namespace TouristicPropositions.Classes
{
    public abstract class BasiVoucher : IInfo, IComparable<BasiVoucher>
    {
        private int _price = 1;
        public abstract string TypeName { get; }

        public int Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
        public string Country { get; set; }
        public string HotelClass { get; set; }
        public string Meal { get; set; }

        public BasiVoucher(int price, string country, string hotelClass, string meal)
        {
            Price = price;
            Country = country;
            HotelClass = hotelClass;
            Meal = meal;
        }


        public void GetPrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Type is {TypeName}, Price is {Price}, Country is {Country}, Class of the Hotel {HotelClass}, Meal: {Meal}  ";
        }

       

        public int CompareTo(BasiVoucher other)
        {
            int compare;
            compare = this.Price.CompareTo(other.Price);
            return compare;
            
           
        }
    }
}
