using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_3_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,max,mid,min;
            Console.WriteLine("enter 3 integer no");
            a=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter 3 integer no");
            b=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("enter 3 integer no");
            c=Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                max = a;
            {
                if (b > c)
                    max = b;
                
                else
                        max = c;  
            }
            

            if (a < b && a < c)
                min = a;
            {
                if (b < c)
                    min = b;
                else
                    min = c;
            }

            {
            mid = a + b + c - max - min;
            }

            Console.WriteLine("a="+max);
            Console.WriteLine("b="+mid);
            Console.WriteLine("c="+min);
            Console.ReadLine();
        }
    }
}
