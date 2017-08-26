using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of stars: ");
            int starNum = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= starNum; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");                    
                }
                Console.WriteLine();
            }
            for (int i = starNum; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            

            Console.ReadLine();
        }
    }
}
