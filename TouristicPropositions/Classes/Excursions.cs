


namespace TouristicPropositions.Classes
{
    public class Excursions : BasiVoucher
    {
        public Excursions(int price, string country, string hotelClass, string meal) 
            : base(price, country, hotelClass, meal)
        {
        }

        public override string TypeName => "Excursions";
    }
}
