using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter any no");
            int x = Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;

                case 2:
                    Console.WriteLine("monday");
                    break;

                case 3:
                    Console.WriteLine("tuesday");
                    break;

                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("thuresday");
                    break;

                case 6:
                    Console.WriteLine("friday");
                    break;

                case 7:
                    Console.WriteLine("saturday");
                    break;

                default:
                    Console.WriteLine("inviled");
                    break;
            }

            Console.ReadLine();
        }
    }
}
