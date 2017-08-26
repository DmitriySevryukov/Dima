using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 15;

            /*   while (num < 10)
               {
                   if (num == 5)
                   {
                       break;
                   }
                   Console.WriteLine(num++);


               }*/

          /*  do
            {
                Console.WriteLine(num++);
            } while (num < 10);*/


            for (int i = 10; i >= 0; i--)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
