using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class OrderItem : IOrder
    {
        protected string name = string.Empty;
        public double Price { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public OrderItem(string aname, double aprice)
        {
            Price = aprice;
            Name = aname;
        }

        public string GetName()
        {
            return name;
        }

    }
}
