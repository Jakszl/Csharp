using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_HW
{
    internal class FruitBasedIceCream : IceCream
    {
        public bool IsWaffle { get; set; } = false;
        public string Topping { get; set; } = "N/A";

        public FruitBasedIceCream(int aPrice, string aFlavor, bool aIsWaffle, string aTopping) : base(aPrice, aFlavor)
        {
            Topping = aTopping;
            IsWaffle = aIsWaffle;
        }

        public override string TypeOfIceCream { get; set; } = "Fruit Based";
        public override string GetInfo()
        {
            return "Price: " + Price + "\nFlavor: " + Flavor + "\nWaffle: " + IsWaffle
                + "\nTopping: " + Topping + "\nType: " + TypeOfIceCream;
        }

        public FruitBasedIceCream() { }
    }
}
