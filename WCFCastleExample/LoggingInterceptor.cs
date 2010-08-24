using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace WCFCastleExample
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Service:          " + invocation.InvocationTarget.ToString());
            Console.WriteLine("Method signature: " + invocation.Method.ToString());

            foreach (var argument in invocation.Arguments)
                Console.WriteLine("Argument:         " + argument.ToString());

            invocation.Proceed();

            Console.WriteLine("Return value:     " + invocation.ReturnValue.ToString());
        }
    }
}
