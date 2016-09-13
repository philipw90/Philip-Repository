using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagMetod5mk2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int ageInput1 = int.Parse(Console.ReadLine());
            bool ofAge = AgeCheck(ageInput1);

            if (ofAge == false)
            {
                Console.WriteLine("You are not of age");
            }
            else
            {
                Console.WriteLine("you are an adult");
            }


        }

        public static bool AgeCheck(int val1)
        {
            bool returnValue = false;
            if (val1 >= 18)
            {
                returnValue = true;
            }
            return returnValue;
        }
    }
}
