using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal interface IOrder
    {
        
        public double Price { get; set; }
        public string GetName() { return " "; }
    }
}
