using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new ProviderAExternalService());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new ProviderBExternalService());
        }

        private void ClientMethod(IExternalServiceFactory externalServiceFactory)
        {
            Console.WriteLine(externalServiceFactory.GetTracking());
            Console.WriteLine(externalServiceFactory.GetPricing());
            Console.WriteLine(externalServiceFactory.GetShipping());
        }
    }
}
