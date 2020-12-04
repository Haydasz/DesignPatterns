using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class ShippingA : IShipping
    {
        string IShipping.GetShipping()
        {
            return "The result of the ShippingA.";
        }
    }
}
