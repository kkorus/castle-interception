using System;

namespace InterceptionWithCastle
{
    public class MotherFBussinesClass : IMotherFBussinesClass
    {
        public void Method1()
        {
            Console.WriteLine("I am MotherFBussinesClass");
        }
    }
}