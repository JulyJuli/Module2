using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module0604
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "";
            do
            {
                List<BaseVoucher> vouchers = new List<BaseVoucher>()
                {

                new Relaxation (30, Country.Ukraine, 3, Food.WithoutFood),
                new Sanatorium (35, Country.Ukraine, 3, Food.WithoutFood),
                new Shopping (40, Country.Ukraine, 4, Food.BreakfastOnly),
                new Tours (45, Country.Ukraine, 4, Food.BreakfastOnly),

                new Relaxation (100, Country.Germany, 3, Food.WithoutFood),
                new Shopping (120, Country.Germany, 4, Food.BreakfastOnly),
                new Tours (150, Country.Germany, 4, Food.BreakfastOnly),
                new Relaxation (200, Country.Germany, 5, Food.AllInclusive),

                new Tours (300, Country.Dubai, 5, Food.AllInclusive),
                new Shopping (600, Country.Dubai, 5, Food.AllInclusive),
                new Relaxation (450, Country.Dubai, 5, Food.AllInclusive),

                new Relaxation (250, Country.Australia, 3, Food.WithoutFood),
                new Cruise (400, Country.Australia, 3, Food.WithoutFood),
                new Shopping (500, Country.Australia, 4, Food.BreakfastOnly),
                new Tours (310, Country.Australia, 4, Food.BreakfastOnly),
                };


                vouchers.Sort(delegate (BaseVoucher vouchers1, BaseVoucher vouchers2)
                {
                    return vouchers1.Country.CompareTo(vouchers2.Country);
                });


                vouchers.Sort(delegate (BaseVoucher vouchers1, BaseVoucher vouchers2)
                {
                    return vouchers1.Cost.CompareTo(vouchers2.Cost);
                });


                for (int i = 0; i < vouchers.Count; i++)
                {
                    Console.WriteLine(vouchers[i].ToString());
                }

                Console.WriteLine("\nTell me the maximum cost of the desired ticket? Enter max cost please: ");
                double cost = double.Parse(Console.ReadLine());
                List<BaseVoucher> listSordetCost = new List<BaseVoucher>();

                for (int i = 0; i < vouchers.Count; i++)
                {

                    if (cost > vouchers[i].Cost)
                    {
                        Console.WriteLine(vouchers[i].ToString());
                        listSordetCost.Add(vouchers[i]);
                    }
                }

                Console.WriteLine("Tell me in which country do you want to buy a ticket? Enter country please: ");
                Console.WriteLine($"Press 1 - {(Country)1}");
                Console.WriteLine($"Press 2 - {(Country)2}");
                Console.WriteLine($"Press 3 - {(Country)3}");
                Console.WriteLine($"Press 4 - {(Country)4}");


                List<BaseVoucher> listSordetCountry = new List<BaseVoucher>();

                int index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        {
                            for (int i = 0; i < listSordetCost.Count; i++)
                            {
                                if (listSordetCost[i].Country == (Country)1)
                                {
                                    listSordetCountry.Add(listSordetCost[i]);
                                }
                            }
                            break;
                        }

                    case 2:
                        {
                            for (int i = 0; i < listSordetCost.Count; i++)
                            {
                                if (listSordetCost[i].Country == (Country)2)
                                {
                                    listSordetCountry.Add(listSordetCost[i]);
                                }
                            }
                            break;
                        }

                    case 3:
                        {
                            for (int i = 0; i < listSordetCost.Count; i++)
                            {
                                if (listSordetCost[i].Country == (Country)3)
                                {
                                    listSordetCountry.Add(listSordetCost[i]);
                                }
                            }
                            break;
                        }

                    case 4:
                        {
                            for (int i = 0; i < listSordetCost.Count; i++)
                            {
                                if (listSordetCost[i].Country == (Country)4)
                                {
                                    listSordetCountry.Add(listSordetCost[i]);
                                }
                            }
                            break;
                        }
                }


                for (int i = 0; i < listSordetCountry.Count; i++)
                {
                    Console.WriteLine(listSordetCountry[i].ToString());
                }

                List<BaseVoucher> listSordetHotelClass = new List<BaseVoucher>();
                Console.WriteLine("Please select a hotel class 1-5: ");
                int classHotel = int.Parse(Console.ReadLine());

                for (int i = 0; i < listSordetCountry.Count; i++)
                {
                    if (listSordetCountry[i].HotelClass.Equals(classHotel))
                    {
                        listSordetHotelClass.Add(listSordetCountry[i]);
                    }
                }

                for (int i = 0; i < listSordetHotelClass.Count; i++)
                {
                    Console.WriteLine(listSordetHotelClass[i].ToString());
                }

                Console.Write("Again? Press Y or any kay to exit: ");
                again = Console.ReadLine();
            } while (again.Equals("y") || again.Equals("Y"));
        }
    }
}
