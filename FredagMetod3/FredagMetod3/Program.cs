using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagMetod3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter something more");
            string input2 = Console.ReadLine();

            var combinedvalue = Combination(input1, input2);
            Console.WriteLine(combinedvalue);


        }
        public static string Combination(string combinedValue1, string combinedValue2)
        {
            return combinedValue1 + combinedValue2;


        }
    }
}
