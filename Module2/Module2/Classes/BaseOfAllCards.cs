using Module2.Enums;
using System;
using System.Collections.Generic;

namespace Module2.Classes
{
    public class BaseOfAllCards
    {
        public static List<BaseCard> allCards = new List<BaseCard>();

        public static void AddRangeOfCards(List<BaseCard> newCards)
        {
            foreach (var item in newCards)
            {
                allCards.Add(item);
            }
        }

        public static List<BaseCard> GetCardByCountry(string countryStrNumber )
        {
            List<BaseCard> sortingCardsByCountry = new List<BaseCard>();
            if (int.TryParse(countryStrNumber, out int countryNumber))
            {
                if (Enum.IsDefined(typeof(CountriesEnum), countryNumber))
                {

                    for (int i = 0; i < allCards.Count; i++)
                    {
                        if ((int)allCards[i].Country == (countryNumber))
                        {
                            sortingCardsByCountry.Add(allCards[i]);
                        }
                    }
                }
                else
                    PrintErrorMes();
            }
            return sortingCardsByCountry;
        }

        public static List<BaseCard> GetCardByHotelClass(string hotelClassStrNumber)
        {
            List<BaseCard> sortingCardsByHotelClass = new List<BaseCard>();
            if (int.TryParse(hotelClassStrNumber, out int hotelClassNumber))
            {
                if (Enum.IsDefined(typeof(CountriesEnum),hotelClassNumber))
                {

                    for (int i = 0; i < allCards.Count; i++)
                    {
                        if ((int)allCards[i].Country == (hotelClassNumber))
                        {
                            sortingCardsByHotelClass.Add(allCards[i]);
                        }
                    }
                }
                else
                    PrintErrorMes();
            }
            return sortingCardsByHotelClass;
        }

        public static List<BaseCard> GetCardByHotelClassAndCountry(string hotelClassStrNumber, List<BaseCard> sortingCardsByCountry)
        {
            List<BaseCard> sortingCardsByHotelClassAndCountry = new List<BaseCard>();
            if (int.TryParse(hotelClassStrNumber, out int hotelClassNumber))
            {
                if (Enum.IsDefined(typeof(CountriesEnum), hotelClassNumber))
                {

                    for (int i = 0; i < sortingCardsByCountry.Count; i++)
                    {
                        if ((int)sortingCardsByCountry[i].HotelClass == (hotelClassNumber))
                        {
                            sortingCardsByHotelClassAndCountry.Add(sortingCardsByCountry[i]);
                        }
                    }
                }
                else
                    PrintErrorMes();
            }
            return sortingCardsByHotelClassAndCountry;
        }

        private static void PrintErrorMes()
        {
            Console.WriteLine("Incorrect input! Try again!");
        }

        public static  List<BaseCard>SortListByCountry()
        {
            BaseCard item;
            for(int i=0; i<allCards.Count; i++)
            {
                for (int j=i+1; j<allCards.Count;j++)
                {
                    if(allCards[i].Country.CompareTo(allCards[j].Country)==-1)
                    {
                        item = allCards[i];
                        allCards[i] = allCards[j];
                        allCards[j] = item;
                    }
                }

            }
            return allCards;
        }      
       
    }
}
