using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class Program9
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            d1.Sound("WOW WOW");
            c1.Sound("MEOW MEOW");
        }

    }

    public abstract class Animal
    {
        public abstract void Sound(string sound);
    }
    public class Dog : Animal
    {
        public override void Sound(string sound)
        {
            Console.WriteLine("Dog is barking " + sound);
            Console.ReadKey();
        }
    }
    public class Cat : Animal
    {
        public override void Sound(string sound)
        {
            Console.WriteLine("Cat Sound " + sound);
            Console.ReadKey();
        }

    }

}
