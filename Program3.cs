using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal class Program3
    {
        static void Main(string[] args)
        {
            float[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MathHelper.average(nums);
        }
    }

    public static class MathHelper
    {
        static float sum = 0;
        static float avg = 0;
        public static void average(float[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            avg = sum / nums.Length;
            Console.WriteLine("Average is " + avg);
            Console.ReadKey();
        }

    }


}
}
