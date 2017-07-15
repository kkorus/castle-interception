using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace InterceptionWithCastle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IWindsorContainer container = new WindsorContainer();

            container.Register(
                Component.For<MyInterceptorAspect>());

            container.Register(Classes.FromThisAssembly()
                .InSameNamespaceAs<IAnotherBussinesClass>()
                .WithService.DefaultInterfaces()
                .Configure(delegate (ComponentRegistration c)
                {

                    var x = c.Interceptors(InterceptorReference.
                        ForType<MyInterceptorAspect>()).Anywhere;
                }));


            var obj3 = container.Resolve<IMotherFBussinesClass>();
            var obj4 = container.Resolve<IAnotherBussinesClass>();

            obj3.Method1();
            obj4.Method1();
        }
    }
}