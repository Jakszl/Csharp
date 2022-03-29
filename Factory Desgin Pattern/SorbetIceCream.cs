using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class SorbetIceCream : IceCream
    {
        public SorbetIceCream(int aPrice, string aFlavor) : base(aPrice, aFlavor) { }
        public SorbetIceCream() { }

        public override string TypeOfIceCream { get; set; } = "Sorbet";

        public override string GetInfo()
        {
            return "Price: " + Price + "\nFlavor: " + Flavor + "\nType: " + TypeOfIceCream;
        }
    }
}
