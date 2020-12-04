using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class ProviderBExternalService : IExternalServiceFactory
    {
        IPricing IExternalServiceFactory.GetPricing()
        {
            return new PricingB();
        }

        IShipping IExternalServiceFactory.GetShipping()
        {
            return new ShippingB();
        }

        ITracking IExternalServiceFactory.GetTracking()
        {
            return new TrackingB();
        }
    }
}
