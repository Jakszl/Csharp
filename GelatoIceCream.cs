using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class GelatoIceCream : IceCream 
    {
        public bool IsWaffle { get; set; } = false;
        public bool IsSprinkles { get; set; } = false;

        public GelatoIceCream(int aPrice, string aFlavor, bool aIsWaffle, bool aIsSprinkles) : base(aPrice, aFlavor)
        {
            IsSprinkles = aIsSprinkles;
            IsWaffle = aIsWaffle;
        }

        public override string TypeOfIceCream { get; set; } = "Gelato";

        public override string GetInfo()
        {
            return "Price: " + Price + "\nFlavor: " + Flavor + "\nWaffle: " + IsWaffle
                +  "\nSprinkles: " + IsSprinkles + "\nType: " + TypeOfIceCream;
        }

        public GelatoIceCream() { }
    }
}
