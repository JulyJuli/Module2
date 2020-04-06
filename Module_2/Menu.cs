using Module2_lib;
using System;
using System.Linq;

namespace Module_2
{
    public static class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Hello, choose an option:\n");

            Console.WriteLine("1 - Display overall info");
            Console.WriteLine("2 - Country select");
            Console.WriteLine("3 - Hotel class select");
            Console.WriteLine("4 - Price class select");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ;
            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.WriteLine(Offers.DisplayAllInfo());
                    Console.ReadKey();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();

                    CountrySelect();

                    Console.ReadKey();
                    break;

                case ConsoleKey.D3:
                    break;

                case ConsoleKey.D4:
                    break;

                default:
                    MainMenu();
                    break;
            }
            MainMenu();
        }
        private static void CountrySelect()
        {
            Console.WriteLine("Select by country: ");

            var desiredCountryVouchers = Offers.Vouchers.GroupBy(v => v.Country).ToList();
            desiredCountryVouchers.ForEach(g => Console.WriteLine(g.Key));

            Console.Write("Type desired country: ");
            string desCountry = Console.ReadLine();

            desiredCountryVouchers.ForEach(g =>
            {
                if (g.Key.ToLower() == desCountry.ToLower())
                {
                    foreach (var item in g.ToList())
                    {
                        Console.WriteLine(item.GetInfo() + "\n");
                    }
                }

                else
                {
                    Console.Write("Wrong country.");
                    CountrySelect();
                }

            });

        }
    }
}
