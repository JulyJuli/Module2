using System;
using System.Collections.Generic;
using Module2_DLL;
using Module2_DLL.Enums;
using Module2_DLL.Utilities;

namespace Module2_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var toursList = new List<BaseTour>
            {
                new Relax(200, "Spain", Meals.BreakfastOnly, 3),
                new Excursion(100, "Cyprus", Meals.BreakfastOnly, 3),
                new Medical(700, "Israel", Meals.AllInclusive, 4),
                new Shopping(400, "Spain", Meals.AllInclusive, 5),
                new Cruise(1000, "Spain", Meals.AllInclusive, 5),
                new Excursion(200, "Israel", Meals.NoMeals, 3)
            };

            Console.Write("Enter your budget: ");
            string budgetInput = Console.ReadLine();
            int budget = InputValidation(budgetInput);

            Console.Write("Enter the country you want to visit: ");
            string country = Console.ReadLine();

            Console.Write("Enter the minimum rank of the hotel (from 1 to 5): ");
            string hotelRankInput = Console.ReadLine();
            int hotelRank = HotelRankValidation(hotelRankInput);

            var suitableTours = TourListMethods.GetSuitableTours(toursList, budget, country, hotelRank);

            TourListMethods.PrintSuitableTours(suitableTours);
        }

        public static int InputValidation(string input)
        {
            int result;

            while (int.TryParse(input, out result) == false)
            {
                Console.Write("The entered value is not a number, please try again: ");
                input = Console.ReadLine();
            }

            return result;
        }

        public static int HotelRankValidation(string input)
        {
            int hotelRank = InputValidation(input);

            while (hotelRank < 1 || hotelRank > 5)
            {
                Console.Write("Entered number is not in range from 1 to 5, please try again: ");
                input = Console.ReadLine();
                hotelRank = InputValidation(input);
            }

            return hotelRank;
        }
    }
}
