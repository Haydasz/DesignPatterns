using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{ 
    internal class ShippingB : IShipping
    {
        public string GetShipping()
        {
            return "The result of the ShippingB.";
        }
    }
}
