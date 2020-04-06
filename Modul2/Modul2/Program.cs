using Modul2.Enums;
using Modul2.Vouchers;
using System;
using System.Collections.Generic;

namespace Modul2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We can offer you such vouchers:\n");

            var vouchers = new TravelAgency();
            vouchers.AddVoucher(new CruiseVoucher(Country.Australia, HotelClass.A, Food.allInclusive, 5000));
            vouchers.AddVoucher(new ExcursionVoucher(Country.Turkish, HotelClass.C, Food.breakfastOnly, 1000));
            vouchers.AddVoucher(new RestVoucher(Country.Albania, HotelClass.D, Food.breakfastOnly, 800));
            vouchers.AddVoucher(new ShoppingVoucher(Country.Italy, HotelClass.A, Food.noMeals, 4000));
            vouchers.AddVoucher(new TreatmentVoucher(Country.Egypt, HotelClass.B, Food.breakfastOnly, 1600));
            vouchers.AddVoucher(new CruiseVoucher(Country.Egypt, HotelClass.C, Food.noMeals, 2000));
            vouchers.AddVoucher(new ExcursionVoucher(Country.Turkish, HotelClass.A, Food.allInclusive, 11000));
            vouchers.AddVoucher(new RestVoucher(Country.Turkish, HotelClass.D, Food.breakfastOnly, 800));
            vouchers.AddVoucher(new ShoppingVoucher(Country.Italy, HotelClass.A, Food.noMeals, 4000));
            vouchers.AddVoucher(new TreatmentVoucher(Country.Egypt, HotelClass.B, Food.breakfastOnly, 1100));
            vouchers.AddVoucher(new CruiseVoucher(Country.Australia, HotelClass.B, Food.allInclusive, 5000));
            vouchers.AddVoucher(new ExcursionVoucher(Country.Turkish, HotelClass.D, Food.noMeals, 700));
            vouchers.AddVoucher(new RestVoucher(Country.Albania, HotelClass.D, Food.breakfastOnly, 1800));
            vouchers.AddVoucher(new ShoppingVoucher(Country.Italy, HotelClass.A, Food.noMeals, 3300));
            vouchers.AddVoucher(new TreatmentVoucher(Country.Egypt, HotelClass.B, Food.breakfastOnly, 2500));


            BaseVoucher.PrintInfo(vouchers.Agency);

            Console.WriteLine("\nPlease, enter the criteria by which we can choose a voucher\n");
            Console.WriteLine("Select type of voucher:\npress 1 - rest\npress 2 - excursion\npress 3 - treatment\npress 4 - shopping\npress 5 - cruise");


            int selectVoucher = int.Parse(Console.ReadLine());
            TypeOfVoucher typeOfVoucher = (TypeOfVoucher)selectVoucher;
            Console.Write($"You selected category: " + typeOfVoucher.ToString() + "\n");


            List<BaseVoucher> foundVouchers = vouchers.SearchVoucher(vouchers.Agency, selectVoucher);
            BaseVoucher.PrintInfo(foundVouchers);

            Console.WriteLine("\nSelect country:");
            Console.WriteLine("Select type of voucher:\npress 1 - Australia\npress 2 - Turkish\npress 3 - Albania\npress 4 - Italy\npress 5 - Egypt");

            int selectCountry = int.Parse(Console.ReadLine());
            Country country = (Country)selectCountry;
            Console.Write($"You selected category: " + country.ToString() + "\n");
            foundVouchers = vouchers.SearchCountry(foundVouchers, selectCountry);
            BaseVoucher.PrintInfo(foundVouchers);

            Console.WriteLine("\nSelect hotel class:");
            Console.WriteLine("Select type of voucher:\npress 1 - A\npress 2 - B\npress 3 - C\npress 4 - D");

            int selectHotelClass = int.Parse(Console.ReadLine());
            HotelClass hotelClass = (HotelClass)selectHotelClass;
            Console.Write($"You selected category: " + hotelClass.ToString() + "\n");
            foundVouchers = vouchers.SearchHotel(foundVouchers, selectHotelClass);
            BaseVoucher.PrintInfo(foundVouchers);

            Console.WriteLine("\nSelect price of voucher:");
            int price = int.Parse(Console.ReadLine());
            for (int i = 0; i < foundVouchers.Count; i++)
            {
                if (price >= foundVouchers[i].Price)
                {
                    Console.WriteLine(foundVouchers[i].ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
