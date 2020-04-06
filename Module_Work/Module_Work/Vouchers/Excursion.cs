using System;
using Module_Work.Utils;

namespace Module_Work.Vouchers
{
    public class Excursion : BaseTravelVoucher
    {
        protected override string TravelVoucherType => "Excursion";
        public override FoodGrade Type => FoodGrade.All;
        public Excursion(int price, string countreOfRest, int classOfHotel, string foodGrage) : base(price, countreOfRest, classOfHotel, foodGrage)
        {

        }
    }
}
