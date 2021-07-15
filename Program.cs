using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        
        static void s(ref int a,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("enter 3 integer no");
             x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            if (x > y)
                s(ref x, ref y);

            if (y > z)
                s(ref y, ref z);

            if (x > y)
                s(ref x, ref y);


            Console.WriteLine("x value={0}",x);
            Console.WriteLine("y value={0}", y);
            Console.WriteLine("z value={0}", z);

            Console.ReadLine();
        }
    }
}
