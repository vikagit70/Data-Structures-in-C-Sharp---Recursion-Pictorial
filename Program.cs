using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictorial
{
    class Program
    {
        static void Division(int n, int n1, int join, int i)
        {
            if (n < 1 || n1 < 1)
            {
                Console.WriteLine("Either of the numbers is less than 1");
                //return;
            }
            else
            {
                if (i < n && i < n1)
                {
                    if (n % i == 0 && n1 % i == 0)
                    {
                        join = join * i;
                        int divide = n / i;
                        int divide1 = n1 / i;
                        Division(divide, divide1, join, i++);
                    }
                    else
                    {
                        Division(n, n1, join, i + 1);
                    }
                }
                else
                {
                    Console.WriteLine("G.C.D. = " + join);
                    Console.WriteLine("L.C.M. = " + n * n1 * join);
                }
            }
        }
        static void Main(string[] args)
        {
            int join1 = 1;
            int ii = 2;
            Console.Write("input n: ");
            int userInput1 = Int32.Parse(Console.ReadLine());
            Console.Write("input n1: ");
            int userInput2 = Int32.Parse(Console.ReadLine());
            Division(userInput1, userInput2, join1, ii);
            Console.WriteLine("The End");
        }
    }
}
