using Module2_lib;
using Module2_lib.Utils;
using System;
using System.Collections.Generic;

namespace Module_2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Vocation voc1 = new Vocation("Ukraine", 200, HotelType.ThreeStar, NutritionType.Breakfasts);
            Voucher tour1 = new Tours("USA", 150, HotelType.FourStar, NutritionType.AllInclusive);
            Cure cure1 = new Cure("Ukraine", 100, HotelType.ThreeStar, NutritionType.AllInclusive);
            Shopping shopping1 = new Shopping("Brasil", 300, HotelType.FiveStar, NutritionType.NoFood);
            Cruise cruise1 = new Cruise("Atlantic ocean", 500, HotelType.FiveStar, NutritionType.AllInclusive);

            Offers offers = new Offers();

            Offers.Vouchers.AddRange(new List<Voucher> { voc1, tour1, cure1, shopping1, cruise1 });

            Offers.Vouchers.AddRange(new List<Voucher>
                {
                new Vocation("Germany", 180, HotelType.TwoStar, NutritionType.Breakfasts),
                new Vocation("Germany", 350, HotelType.FiveStar, NutritionType.Breakfasts)
                }
                );

            //Console.WriteLine(tour1.GetInfo());

            Menu.MainMenu();

            Console.ReadKey();
        }
    }


}
