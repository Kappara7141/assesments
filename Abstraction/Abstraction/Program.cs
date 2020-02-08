using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Animal
    {
        public abstract void eat();
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Rat : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread");
        }

    }
    public class Test
    {
        static void Main()
        {
            Animal a;
            a = new Dog();
            a.eat();
            a = new Rat();
            a.eat();
        }
    }

}

