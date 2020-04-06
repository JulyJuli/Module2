using Module2_lib.Utils;
using System;

namespace Module2_lib
{
    public abstract class Voucher
    {
        private decimal _price;
        public abstract string VoucherType { get; }
        public string Country { get; protected set; }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0;
                    Console.Write("Price must be > 0, was set as 0.");
                }
            }
        }
        public HotelType HotelClass { get; protected set; }
        public NutritionType Nutrition { get; protected set; }

        public Voucher(string country, decimal price, HotelType hotelClass, NutritionType food)
        {
            Country = country;
            Price = price;
            HotelClass = hotelClass;
            Nutrition = food;
        }

        public string GetInfo()
        {
            string res = string.Empty;

            res += $"Voucher type: {VoucherType};\n";
            res += $"Country: {Country};\n";
            res += $"Price: {Price:F2}, $;\n";
            res += $"Hotel class: {PrintHotelClass()};\n";
            res += $"Nutrition type: {Nutrition}.\n";

            return res;
        }

        private string PrintHotelClass()
        {
            string res = string.Empty;

            switch (HotelClass)
            {
                case HotelType.OneStar:
                    res += "one star";
                    break;

                case HotelType.TwoStar:
                    res += "two stars";
                    break;

                case HotelType.ThreeStar:
                    res += "three stars";

                    break;

                case HotelType.FourStar:
                    res += "four stars";
                    break;

                case HotelType.FiveStar:
                    res += "five stars";
                    break;

                default:
                    res += "Error in hotel switch ";
                    break;
            }

            return res;
        }

        private string PrintNutritionType()
        {
            string res = string.Empty;
            switch (Nutrition)
            {
                case NutritionType.NoFood:
                    res += $"no nutrition included";
                    break;

                case NutritionType.Breakfasts:
                    res += $"breakfasts included";
                    break;

                case NutritionType.AllInclusive:
                    res += $"eat as much as you can";
                    break;

                default:
                    res += "Error in nutrition switch ";
                    break;
            }

            return res;
        }
    }
}
