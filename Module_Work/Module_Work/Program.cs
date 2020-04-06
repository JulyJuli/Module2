using System;
using System.Collections.Generic;
using Module_Work.Vouchers;


namespace Module_Work
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vouchers = new List<BaseTravelVoucher>
            {
                new Relaxation(10000,"Albania",4,"BB"),
                new Excursion(1500,"Czech",5,"All"),
                new Treatment(2100,"Ukraine",2,"RO"),
                new Shopping(23000,"France",4,"BB"),
                new Cruise(34050,"Georgia",3,"All")
            };                    

            int i;

            Console.Write("Menu\n1) Viev travel vouchers \n2) Search by.. \n3) Sort by.. \nExit ");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    vouchers.ForEach(voucher => voucher.PrintInfo());
                break;
                case 2:
                    Console.Clear();
                Console.Write("select search type:\n1) Search by price \n2) Search by country \n3) Search by class of hotel \nExit ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        //vouchers.FindAll(vouchers, x => x >= 1000 && x <=14000 );                            
                        break;
                    case 2:
                        Console.WriteLine("Enter country");
                        string country = Console.ReadLine();
                        Console.WriteLine(vouchers.FindAll(voucher => voucher.CountryOfRest == country));
                        break;
                    case 3:
                        Console.WriteLine("Enter class of hotel ->|1,2,3,4 or 5 stars");
                        int classHotel = int.Parse(Console.ReadLine());
                        Console.WriteLine(vouchers.FindAll(voucher => voucher.ClassOfHotel == classHotel));
                        break;
                }
                break;
                case 3:
                    vouchers.Sort((x, y) => x.CountryOfRest.CompareTo(y.CountryOfRest));
                break;
            }
            
            Console.ReadLine();
            Console.Clear();
        }
    }
}
