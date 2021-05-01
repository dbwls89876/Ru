using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.recursion
{
    class _10872_factorial
    {
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * factorial(n - 1);

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial(n));
            Console.ReadLine();
        }
    }
}
