using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism
{
    public abstract class Duck
    {
        protected FlyBehavior FlyBehavior;
        protected QuackBehavior QuackBehavior;
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        public abstract void BreakWings();
    }

    public class RedHeadDuck: Duck
    {
        public RedHeadDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }

        public override void BreakWings()
        {
            Console.WriteLine("Oh no, I crashed with a three and cannot fly anymore");
            FlyBehavior = new FlyNoWay();
        }
    }

    public interface FlyBehavior
    {
        public abstract void Fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying like a lightning");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("My wings don't allow me to fly");
        }
    }

    public interface QuackBehavior
    {
        public void Quack();
    }

    public class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
