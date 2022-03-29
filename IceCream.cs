using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    abstract class IceCream
    {
        private int price = 0;
        public int Price
        {
            get { return this.price; }
            set 
            {
                if (value > 0) { this.price = value; }
                else { this.price = -value; }
            }
        }
        public string Flavor { get; set; } = "N/A";

        public IceCream(int aPrice, string aFlavor)
        {
            Price = aPrice;
            Flavor = aFlavor;
        }

        public abstract string GetInfo();

        public abstract string TypeOfIceCream { get; set; }

        public IceCream() { }
       
    }
}
