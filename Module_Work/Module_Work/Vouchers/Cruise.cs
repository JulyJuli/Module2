using Module_Work.Utils;

namespace Module_Work.Vouchers
{    
    public class Cruise : BaseTravelVoucher
    {
        protected override string TravelVoucherType => "Cruise";
        public override FoodGrade Type => FoodGrade.All;
        public Cruise(int price, string countreOfRest, int classOfHotel, string foodGrage) : base(price, countreOfRest, classOfHotel, foodGrage)
        {

        }
    }
}
