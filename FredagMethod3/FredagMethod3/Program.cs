using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something");
            var inp1 = Console.ReadLine();
            Console.WriteLine("Write something else");
            var inp2 = Console.ReadLine();

            var totalValue = Combination(inp1, inp2);
            Console.WriteLine(totalValue);

        }

        static string Combination(string input1, string input2)
        {
            var combineInput = input1 + input2;
            return combineInput;
        }
    }
}
