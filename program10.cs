using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class Program10
    {
        static void Main(string[] args)
        {
            Car Audi = new Car("Audi");

        }

    }

    public sealed class Vechile
    {
        string vechile;
        public void startEngine(string vechile)
        {
            this.vechile = vechile;
            Console.WriteLine(vechile + " is start");
        }
        public void stopEngine()
        {

            Console.WriteLine(vechile + "is stop");
        }
    }

    public class Car : Vechile
    {
        string name;
        public Car(string name)
        {
            this.name = name;
        }
    }

}
