using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.recursion
{
    class _10870_fibonacci
    {
        static int fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(fibonacci(n));
        }
    }
}
