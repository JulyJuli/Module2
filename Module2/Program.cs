using Module2.Voucher;
using System;
using System.Collections.Generic;

namespace Module2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var vouchersList = new List<BaseVoucher>()
            {
                new Cruise(60,5,"Cruisefrst", "Egypt", "only breakfast"),
                new Relaxation(22,5,"Relaxationfrst", "Egypt", "all inclusive"),
                new Shopping(43,4,"Shop", "Milan", "only breakfast"),
                new Tours(22,3,"Toursfrst", "Moskov", "no meals"),
                new Treatment(34,4,"Treatmentfrst", "Ukraine", "only breakfast")
            };
            while (true)
            {
                Console.WriteLine("Input your criterion price, class hotel, country: ");
                string criterion = Console.ReadLine();
                if (criterion == "price")
                {
                    Console.WriteLine("Input your criterion price: ");
                    int price = int.Parse(Console.ReadLine());

                    foreach (var voucher in vouchersList)
                    {
                        var voucherPrice = voucher.Price;
                        if (voucherPrice <= price)
                        {
                            Console.WriteLine(voucher.ToString());
                            Console.ReadLine();

                        }

                    }
                }
                if (criterion == "class hotel")
                {
                    Console.WriteLine("Input your criterion class hotel: ");
                    int classHotel = Int32.Parse(Console.ReadLine());
                    foreach (var voucher in vouchersList)
                    {
                        var voucherClassHotel = voucher.HotelClass;
                        if (voucherClassHotel == classHotel)
                        {
                            Console.WriteLine(voucher.ToString());
                            Console.ReadLine();
                        }

                    }
                }
                if (criterion == "country")
                {
                    Console.WriteLine("Input your criterion country: ");
                    string country = Console.ReadLine();

                    foreach (var voucher in vouchersList)
                    {
                        var voucherPrice = voucher.CountryOfRest;
                        if (voucherPrice == country)
                        {
                            Console.WriteLine(voucher.ToString());
                            Console.ReadLine();


                        }

                    }
                }
                else
                {
                    Console.WriteLine("Nothing more suits, please change your criteria");
                }
                Console.WriteLine("if you want close input break");
                string close = Console.ReadLine();
                if (close == "break")
                {
                    break;
                }
            }



            Console.ReadLine();
        }
    }
}
