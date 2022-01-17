using System;

namespace QuadraticFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double disc, deno, x1, x2;

            Console.WriteLine("Enter parameters for a, b and c: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are linear.");
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;

                if (disc > 0)
                {
                    Console.WriteLine("The roots are real and distinct roots.");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("The roots are: " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("The roots are repeated roots.");
                    x1 = -b / deno;
                    Console.WriteLine("The root is" + x1);
                }
                else
                {
                    Console.WriteLine("The roots are imaginary roots. You can't solve this equation.");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);
                    Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);
                }
            }
            Console.ReadLine();
        }
    }
}
