using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //static int i, j;
        static void a()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 2 || i == 1 && j == 3 || i <= 5 && j == 4 || i == 3 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if(i!=5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void b()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i <= 5 && j == 3 || i == 1 && j == 2 || i == 3 && j == 2 || i == 5 && j == 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void c()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j <= 3 || i == 5 && j <= 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void d()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j <= 5 || i <= 5 && j == 5 || i == 5 && j <= 5 || i <= 5 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void e()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j <= 3 || i == 3 && j <= 3 || i == 5 && j <= 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        } 
        
        static void f()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j <= 3 || i == 3 && j <= 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void g()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j <= 4 || i == 5 && j <= 4 || i == 3 && j == 3 || i == 3 && j == 4 || i == 4 && j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void h()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i <= 5 && j == 3 || i == 3 && j == 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void i()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j <= 3 || i == 5 && j <= 3 || i <= 5 && j == 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void j()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j <= 5 || i <= 5 && j == 3 || i == 5 && j <= 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }


        static void k()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j == 3 || i == 2 && j == 2 || i == 4 && j == 2 || i == 5 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void l()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 5 && j <= 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void m()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i <= 5 && j == 5 || i == 3 && j == 3 || i == 2 && j == 2 || i == 2 && j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void n()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i <= 5 && j == 5 || i == j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void o()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 2 || i <= 5 && j == 4 || i == 1 && j == 3 || i == 5 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void p()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j <= 3 || i == 3 && j <= 3 || i == 2 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void q()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 4 && j == 1 || i == 1 && j <= 4 || i <= 4 && j == 4 || i == 4 && j <= 4 || i == 3 && j == 3 || i == 5 && j == 5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void r()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i == 1 && j <= 3 || i == 3 && j <= 3 || i == 2 && j == 3 || i == 4 && j == 2 || i == 5 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void s()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j <= 4 || i == 5 && j <= 4 || i == 3 && j <= 4 || i == 4 && j == 4 || i == 2 && j == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void t()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j <= 5 || i <= 5 && j == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
        static void u()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i <= 5 && j == 4 || i == 5 && j <= 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void v()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 4 && j == 1 || i <= 4 && j == 3 || i == 5 && j == 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void w()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i <= 5 && j == 1 || i <= 5 && j == 5 || i == 3 && j == 3 || i == 4 && j == 2 || i == 4 && j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void x()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == j || j == 6 - i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void y()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 3 && j == 3 || i == 4 && j == 3 || i == 5 && j == 3 || i == 1 && j == 1 || i == 2 && j == 2 || i == 2 && j == 4 || i == 1 && j == 5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void z()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i == 1 && j <= 5 || i == 5 && j <= 5 || j == 6 - i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                if (i != 5)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }



        static void Main(string[] args)
        {  
            Console.WriteLine("enter any Alphabet");
            char ch = Convert.ToChar(Console.ReadLine());  //store value 
            char val = Char.ToUpperInvariant(ch);  //convert any chareacter in upper case

           
            switch (val)
            {
                case 'A':
                    a();    
                    break;

                case 'B':
                    b();
                    break;

                case 'C':
                    c();
                    break;

                case 'D':
                    d();
                    break;

                case 'E':
                    e();
                    break;

                case 'F':
                    f();
                    break;

                case 'G':
                    g();
                    break;

                case 'H':
                    h();
                    break;

                case 'I':
                    i();
                    break;

                case 'J':
                    j();
                    break;

                case 'K':
                    k();
                    break;

                case 'L':
                    l();
                    break;

                case 'M':
                    m();
                    break;

                case 'N':
                    n();
                    break;

                case 'O':
                    o();
                    break;

                case 'P':
                    p();
                    break;

                case 'Q':
                    q();
                    break;

                case 'R':
                    r();
                    break;

                case 'S':
                    s();
                    break;

                case 'T':
                    t();
                    break;

                case 'U':
                    u();
                    break;

                case 'V':
                    v();
                    break;

                case 'W':
                    w();
                    break;

                case 'X':
                    x();
                    break;

                case 'Y':
                    y();
                    break;

                case 'Z':
                    z();
                    break;

                default:
                    Console.WriteLine("inviled");
                    break;

            }

            Console.ReadLine();
        }
    }
}
