using Module2_OlehHarmash.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module2_OlehHarmash.VauchersBase
{
    public class Vaucher
    {
        public Vaucher()
        {
            Travel = new List<ITravel>();
        }


        public List<ITravel> Travel { get; set; }
    }
}
