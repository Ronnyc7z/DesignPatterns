using System;

namespace Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {

            //A a = new A();
            //B b = new B();
            //C c = new C();

            //a.Test();
            //b.Test();
            //c.Test();

            //a = new B();
            //a.Test();

            //b = new C();
            //b.Test();

            //Console.ReadKey();

            //Duck behavior testing

            Duck duck = new RedHeadDuck();
            duck.PerformFly();
            duck.BreakWings();
            duck.PerformFly();
        }
    }

    class A
    {
        public virtual void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public override void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public new void Test() { Console.WriteLine("C::Test()"); }
    }
}