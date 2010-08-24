using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using Castle.Facilities.WcfIntegration;
using Castle.Facilities.WcfIntegration.Rest;
using Castle.Core;

namespace WCFCastleExample
{
    /// <summary>
    /// A simple example that integrates a WCF REST interface
    /// with the Castle Windsor IoC container using the Windsor WCFFacility.
    /// 
    /// The service has an interceptor that prints information to the console
    /// whenever the service is called.
    /// 
    /// To see it in action:
    ///   1. Run the service
    ///   2. Type the following URL into your browser:
    /// 
    ///     http://localhost:8080/sum/4/5
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer()
                .AddFacility<WcfFacility>()
                .Register(Component.For<ICalculator>()
                                    .ImplementedBy<Calculator>()
                                    .AsWcfService(new RestServiceModel("http://localhost:8080"))
                                    .Interceptors(InterceptorReference.ForType<LoggingInterceptor>()).Anywhere,
                          Component.For <LoggingInterceptor>()
                );

            Console.WriteLine("Service Started...");
            Console.WriteLine("Logging interceptor output to console:");
            Console.ReadKey();
        }
    }
}
