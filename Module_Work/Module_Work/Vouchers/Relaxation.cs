
using Module_Work.Utils;

namespace Module_Work.Vouchers
{
    public class Relaxation:BaseTravelVoucher
    {
        protected override string TravelVoucherType => "Relaxation";
        public override FoodGrade Type => FoodGrade.BB;
        public Relaxation(int price, string countreOfRest, int classOfHotel, string foodGrage):base(price, countreOfRest, classOfHotel, foodGrage)
        {

        }        
    }
}
