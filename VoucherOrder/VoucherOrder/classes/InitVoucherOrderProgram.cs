using System;
using System.Collections.Generic;
using VoucherOrder.enums;

namespace VoucherOrder.classes
{
    public class InitVoucherOrderProgram
    {
        public InitVoucherOrderProgram()
        {
            Vouchers = new List<VoucherBase>();
            StartProgram();
        }
        
        public List<VoucherBase> Vouchers { get; }

        private void StartProgram()
        {
            Console.Clear();
            getData();
        }

        private void getData()
        {
            Vouchers.AddRange(new List<VoucherBase>()
            {
                new Cruise(1500, "Ukraine", 3, FoodType.AllInclusive),
                new Cruise(1000, "Egypt", 5, FoodType.BreakfastOnly),
                new Relaxation(2000, "Egypt", 4, FoodType.WithoutFood),
                new Relaxation(2500, "Georgia", 1, FoodType.WithoutFood),
                new Shopping(1400, "Georgia", 2, FoodType.BreakfastOnly),
                new Shopping(1600, "Greece", 4, FoodType.AllInclusive),
                new Tours(2100, "Greece", 1, FoodType.WithoutFood),
                new Tours(3100, "USA", 3, FoodType.BreakfastOnly),
                new Treatment(2050, "USA", 4, FoodType.WithoutFood),
                new Treatment(1050, "Ukraine", 2, FoodType.WithoutFood),
            });
        }

        public void FilterByPrice(int min, int max)
        {
            Vouchers.ForEach(voucher =>
            {
                if (voucher.Price >= min && voucher.Price <= max)
                {
                    Console.WriteLine(voucher.ToString());
                }
            });
        }
        
        public void FilterByCountry(string country)
        {
            Vouchers.ForEach(voucher =>
            {
                if (voucher.Country.Equals(country))
                {
                    Console.WriteLine(voucher.ToString());
                }
            });
        }
        
        public void FilterByFoodType(FoodType food)
        {
            Vouchers.ForEach(voucher =>
            {
                if (voucher.Food.Equals(food))
                {
                    Console.WriteLine(voucher.ToString());
                }
            });
        }
        
        public void FilterByHotelClass(int min, int max)
        {
            Vouchers.ForEach(voucher =>
            {
                if (voucher.HotelClass >= min && voucher.HotelClass <= max)
                {
                    Console.WriteLine(voucher.ToString());
                }
            });
        }
        
        public void SortingByPrice()
        {
            Vouchers.Sort();
            Vouchers.ForEach(voucher => Console.WriteLine(voucher.ToString()));
        }
        
        public void SortingByCountry()
        {
            Vouchers.Sort((VoucherBase x, VoucherBase y) => 
            {
                if (x.Country == null && y.Country == null) return 0;
                else if (x.Country == null) return -1;
                else if (y.Country == null) return 1;
                else return x.Country.CompareTo(y.Country);
            });
            Vouchers.ForEach(voucher => Console.WriteLine(voucher.ToString()));
        }
    }
}