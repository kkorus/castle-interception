using System;
using Castle.DynamicProxy;

namespace InterceptionWithCastle
{
    public class MyInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            WriteMessage(invocation, "Before method ", ConsoleColor.DarkYellow);
            invocation.Proceed();
            WriteMessage(invocation, "End method ", ConsoleColor.Yellow);
        }

        public void WriteMessage(IInvocation invocation, string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message +
                              invocation.Method.DeclaringType.Name + "." + invocation.Method.Name
                              + " in " + invocation.Method.Module.Name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}