using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredagMetoder5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            string ofAge = AgeCheck(age)
        }

        public static void AgeCheck(int ageInput)
        {
            if (ageInput < 18)
            {
                Console.WriteLine("You are underage");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }
        }
    }
}
