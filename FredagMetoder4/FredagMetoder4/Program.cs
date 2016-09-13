using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagMetoder4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total value");
            int totValue = int.Parse(Console.ReadLine());

            float vat = ToVat(totValue);
            Console.WriteLine(vat);

        }

        private static float ToVat(int totalSum)
        {
            float retur =(float) (totalSum*0.25);
            return retur;
        }
    }
}
