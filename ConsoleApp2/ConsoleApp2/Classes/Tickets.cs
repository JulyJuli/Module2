using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classes
{
    class Tickets
    {
        private string hotellclass;
        private string country;
        private double price;
        private string pitanie;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string HotellClass
        {
            get { return hotellclass; }
            set { hotellclass = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Pitanie
        {
            get { return pitanie; }
            set { pitanie = value; }
        }

    }
}
