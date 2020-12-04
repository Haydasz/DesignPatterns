using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IExternalServiceFactory
    {
        public ITracking GetTracking();
        public IPricing GetPricing();
        public IShipping GetShipping();
    }
}
