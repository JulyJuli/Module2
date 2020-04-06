


namespace TouristicPropositions.Classes
{
    public class Relax : BasiVoucher
    {
        public Relax(int price, string country, string hotelClass, string meal) 
            : base(price, country, hotelClass, meal)
        {
        }

        public override string TypeName => "Relax";
    }
}
