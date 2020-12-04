
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ProviderAExternalService : IExternalServiceFactory
    {
        public IPricing GetPricing()
        {
            return new PricingA();
        }

        public IShipping GetShipping()
        {
            return new ShippingA();
        }

        public ITracking GetTracking()
        {
            return new TrackingA();
        }
    }
}
