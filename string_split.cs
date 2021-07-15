using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "my name is roushan kumar";
            string [] str1 = str.Split(' ');
            foreach (var p in str1)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
