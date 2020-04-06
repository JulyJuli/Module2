using Module2.Interface;
using System;

namespace Module2.Voucher
{
    public class BaseVoucher : IVoucher
    {
        private int _price = 1;
        public BaseVoucher(int price, int classHotel, string voucherName, string country, string food)
        {
            Price = price;
            HotelClass = classHotel;
            VoucherName = voucherName;
            CountryOfRest = country;
            Food = food;
        }
        public virtual string VoucherName { get; }
        public virtual int Price 
        { 
            get=>_price; 
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            } 
        }
        public virtual string CountryOfRest { get; set; }
        public virtual int HotelClass { get; set; }
        public virtual string Food { get; set; }

        public void Sort()
        {
            int i, j, l;
            string temp;
            l = CountryOfRest.Length;
            for (i = 0; i < l; i++)
            {
                for (j = 0; j < l - 1; j++)
                {
                    if (CountryOfRest[j].CompareTo(CountryOfRest[j + 1]) > 0)
                    {
                        temp = CountryOfRest;
                        CountryOfRest = CountryOfRest;
                        CountryOfRest = temp;
                    }
                }
            }
            for (i = 0; i < l; i++)
            {
                Console.WriteLine(CountryOfRest[i]);
            }
        }

        public override string ToString()
        {
           return $"Voucher: {VoucherName}, has price {Price}," +
                $" has hotel class {HotelClass}, {CountryOfRest},and food {Food}"; 
        }
    }
}
