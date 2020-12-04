using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    internal class PricingA : IPricing
    {
        public string GetPricing()
        {
            return "The result of the PricingA.";
        }
    }
}
