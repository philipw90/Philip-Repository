using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FredagMetoder4mk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = {2, 2, 2, 2};
            var output1 = Sum(myArray);
            var output2 = Mult(myArray);
            Console.WriteLine(output1);
            Console.WriteLine(output2);
        }

        static int Sum(int[] addArray)
        {
            int totalSum = 0;
            for (int i = 0; i < addArray.Length; i++)
            {
                totalSum += addArray[i];
            }
            return totalSum;

        }

        static int Mult(int[] multArray)
        {
            int sum = 1;
            for (int i = 0; i < multArray.Length; i++)
            {
                sum = (sum*multArray[i]);
            }
            return sum;
        }
    }
}
