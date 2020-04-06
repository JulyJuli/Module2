


namespace TouristicPropositions.Classes
{
    public class Shopping : BasiVoucher
    {
        public Shopping(int price, string country, string hotelClass, string meal) 
            : base(price, country, hotelClass, meal)
        {
        }

        public override string TypeName => "Shopping";
    }
}
