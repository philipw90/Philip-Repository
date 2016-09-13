using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultat = 0;
            int counter = 0;
            while (counter < 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    resultat = resultat + 1;
                }
                counter++;

            }
            Console.WriteLine(resultat);
        }
    }
}
