using System;

namespace InterceptionWithCastle
{
    public class AnotherBussinesClass : IAnotherBussinesClass
    {
        public void Method1()
        {
            Console.WriteLine("I am AnotherBussinesClass");
        }
    }
}