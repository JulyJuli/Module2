


namespace TouristicPropositions.Classes
{
    public class Cruise : BasiVoucher
    {
        public Cruise(int price, string country, string hotelClass, string meal) 
            : base(price, country, hotelClass, meal)
        {
        }

        public override string TypeName => "Cruise";
    }
}
