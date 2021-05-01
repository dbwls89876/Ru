using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.recursion
{
    class _2447_star
    {
        static void star(int n1, int n2)
        {
            //if (n1 % 3 == 2 && n2 % 3 == 2)
            //{
            //    Console.WriteLine(" ");
            //}
            //else if (n1>3)
            //{
            //    star(n1 / 3, n2/3);
            //    star((n1 - 1) / 3, (n2-1)/3);
            //    star((n1 - 2) / 3, (n2-1)/3);
            //}
            //else
            //{
            //            Console.WriteLine("*");
            //} 분할 정복 공부 후에 풀어보기

        }

        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            star(n, n);
            Console.ReadLine();
        }
    }
}
