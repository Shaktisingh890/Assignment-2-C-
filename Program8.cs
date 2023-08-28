using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.setRadius(5);
            c1.getarea();
        }

    }

    public abstract class Shape
    {
        public abstract void getarea();
    }
    public class Circle : Shape
    {
        float radius;
        public void setRadius(float r)
        {
            radius = r;
        }
        public override void getarea()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Area is :" + area);
            Console.ReadKey();
        }
    }
}
