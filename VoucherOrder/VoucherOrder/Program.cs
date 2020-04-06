using System;
using VoucherOrder.classes;
using VoucherOrder.enums;

namespace VoucherOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var voucherOrder = new InitVoucherOrderProgram();
            
            Console.WriteLine("\n-------------- All Vouchers --------------------------------");
            voucherOrder.Vouchers.ForEach(Console.WriteLine);
            
            Console.WriteLine("\n-------------- Filter by price 1500 => 2500 ----------------");
            voucherOrder.FilterByPrice(1500, 2500);
            
            Console.WriteLine("\n-------------- Filter by country = Greece ------------------");
            voucherOrder.FilterByCountry("Greece");
            
            Console.WriteLine("\n-------------- Filter by hotel class 2 => 4 ----------------");
            voucherOrder.FilterByHotelClass(2, 4);
            
            Console.WriteLine("\n-------------- Filter by food type = All Inclusive ---------");
            voucherOrder.FilterByFoodType(FoodType.AllInclusive);
            
            Console.WriteLine("\n-------------- Sorting By Price ----------------------------");
            voucherOrder.SortingByPrice();
        }
    }
}