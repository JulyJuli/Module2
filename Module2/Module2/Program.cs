using Module2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        //Туристические путевки.

        //Сформировать набор предложений для клиента по выбору туристической путевки различного типа
        //(отдых, экскурсии, лечение, шопинг, круиз и т.д.)Путевка характеризуется стоимостью, страной отдыха, 
        //классом отеля, питанием(только завтраки, все включено, без питания).
        //Реализовать выбор путевки, подходящей клиенту по различным критериям: стоимость , страна, класс отеля.
        //Добавить сортировку путевок по странам и стоимости.

        public static void PrintList(List<BaseCard> listCards)
        {
            foreach (var item in listCards)
                Console.WriteLine(item);
        }
        static void Main(string[] args)
        {

            var cruise1 = new Cruise(563, Enums.CountriesEnum.Turkey, Enums.HotelTypes.fiveStar, Enums.FoodTypes.allInclusive);
            Console.WriteLine(cruise1);
            BaseOfAllCards.allCards.AddRange(new List<BaseCard>
            {
                new Cruise(563, Enums.CountriesEnum.Turkey, Enums.HotelTypes.fiveStar, Enums.FoodTypes.allInclusive),
                new Shopping(234.50M, Enums.CountriesEnum.America, Enums.HotelTypes.threeStar, Enums.FoodTypes.noMeals),
                new Treatment(560,Enums.CountriesEnum.Spain, Enums.HotelTypes.fourStar, Enums.FoodTypes.breakfastSupper),
                new Rest(489, Enums.CountriesEnum.France, Enums.HotelTypes.threeStar, Enums.FoodTypes.breakfastSupper),
                new Rest(200, Enums.CountriesEnum.France, Enums.HotelTypes.twoStar, Enums.FoodTypes.breakfastOnly),
                new Rest(189, Enums.CountriesEnum.France, Enums.HotelTypes.oneStar, Enums.FoodTypes.noMeals)

        });
            Console.WriteLine("Programm for choose Card:");

            Console.WriteLine("\nInput the desired country:\n 1-France, 2- Spain, 3-China, 4-Italy, 5- America,6- Russia, 7-Turkey, 8-Canada");
           // string a = Console.ReadLine();
            var sortListByCountry = BaseOfAllCards.GetCardByCountry(Console.ReadLine());
            PrintList(sortListByCountry);
            Console.WriteLine("\nInput the desired class of Hotel:\n 1-oneStar, 2-twoStar, 3-threeStar, 4-fourStar, 5-fiveStar");
            var sortListByHotelClassAndCountry = BaseOfAllCards.GetCardByHotelClassAndCountry(Console.ReadLine(), sortListByCountry);
            PrintList(sortListByHotelClassAndCountry);
            var sortListByHotelClass = BaseOfAllCards.GetCardByHotelClass(Console.ReadLine());
            PrintList(sortListByHotelClass);
            Console.WriteLine("Sort List By Country:");
            var sortList=BaseOfAllCards.SortListByCountry();
            PrintList(sortList);
        }
    }
}
