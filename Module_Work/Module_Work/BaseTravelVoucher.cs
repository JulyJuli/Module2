using System;
using Module_Work.Utils;


namespace Module_Work
{
    public abstract class BaseTravelVoucher
    {
        
        protected abstract string TravelVoucherType { get; }
        public abstract FoodGrade Type { get; }
        public BaseTravelVoucher(int price, string countryOfRest, int classOfHotel, string foodGrage)
        {
            Price = price;
            CountryOfRest = countryOfRest;
            ClassOfHotel = classOfHotel;
            FoodGrage = foodGrage;
        }
        public int Price { get; set; }
        public string CountryOfRest { get; set; }
        public int ClassOfHotel { get; set; }
        public string FoodGrage { get; set; }
        public void PrintInfo()       
        {
          Console.WriteLine( $"{TravelVoucherType}:\n" +
              $"Price:{ Price }\n" +
              $"Country Of rest: {CountryOfRest}\n" +
              $"Class of hotel: {ClassOfHotel}\n" +
              $"FoodGrade: {FoodGrage}\n" +
              $"---------------------------------------|");
        }

        
    }
}
