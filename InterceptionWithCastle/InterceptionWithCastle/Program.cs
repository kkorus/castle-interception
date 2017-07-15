using Castle.DynamicProxy;

namespace InterceptionWithCastle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxyGenerator = new ProxyGenerator();

            var obj = proxyGenerator
                .CreateClassProxy<MotherFBussinesClass>(
                    new MyInterceptorAspect()
                );

            var obj2 = proxyGenerator
                .CreateClassProxy<AnotherBussinesClass>(
                    new MyInterceptorAspect()
                );

            obj.Method1();
            obj2.Method1();
        }
    }
}