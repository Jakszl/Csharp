using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class RegularIceCream : IceCream
    {
        public bool IsWaffle { get; set; } = false;
        public string Topping { get; set; } = "N/A";
        public bool IsSprinkles { get; set; } = false;

        public RegularIceCream(int aPrice, string aFlavor, bool aIsWaffle, string aTopping, bool aIsSprinkles):base(aPrice,aFlavor)
        {
            IsSprinkles = aIsSprinkles;
            Topping = aTopping;
            IsWaffle = aIsWaffle;
        }

        public override string TypeOfIceCream { get; set; } = "Regular";

        public override string GetInfo()
        {
            return "Price: " + Price + "\nFlavor: " + Flavor +"\nWaffle: " + IsWaffle 
                + "\nTopping: " + Topping + "\nSprinkles: " + IsSprinkles + "\nType: " + TypeOfIceCream;
        }

        public RegularIceCream() { }

    }
}
