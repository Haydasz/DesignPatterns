using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class PricingB : IPricing
    {
        public string GetPricing()
        {
            return "The result of the PricingB.";
        }
    }
}
