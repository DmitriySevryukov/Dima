using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines(@"D:\D Skripka\azaza.txt");

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
            
        }
    }
}
