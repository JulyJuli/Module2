using System;
namespace Module2.Interface
{
    public interface IVoucher
    {
        int Price { get; set; }
        string CountryOfRest { get; set; }
        int HotelClass { get; set; }
    }
}
