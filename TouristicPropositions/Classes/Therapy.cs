


namespace TouristicPropositions.Classes
{
    public class Therapy : BasiVoucher
    {
        public Therapy(int price, string country, string hotelClass, string meal) 
            : base(price, country, hotelClass, meal)
        {
        }

        public override string TypeName => "Shopping";
    }
}
