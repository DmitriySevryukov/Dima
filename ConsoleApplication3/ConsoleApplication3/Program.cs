using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if ((age >= 0) && (age <= 12))
            {
                Console.Write("You are a child");
            }
            if ((age >= 13) && (age <= 17))
            {
                Console.Write("You are a teenager");
            }
            if ((age >= 18) && (age <= 39))
            {
                Console.Write("You are a young man");
            }
            if ((age >= 40) && (age <= 59))
            {
                Console.Write("You are a man");
            }
            if ((age >= 60) && (age <= 101))
            {
                Console.Write("You are an old man");
            }
            if (age > 101)
            {
                Console.Write("You are dead");
            }

            Console.ReadLine();
        }
    }
}
