using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagMetod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a decimal between 0 and 1");
            float val1 = float.Parse(Console.ReadLine());
            float num1 = ToPercentage(val1);
            Console.WriteLine(num1);
        
        }

        public static float ToPercentage(float value)
        {
            return value = value*100;
        }
    }
}
