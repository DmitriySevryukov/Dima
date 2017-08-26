using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.Write(sum);

            
            

            

            Console.ReadLine();
        }
    }
}
