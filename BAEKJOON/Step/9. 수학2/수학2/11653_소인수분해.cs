using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학2
{
    class _11653_소인수분해
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1) return;
            List<int> list = new List<int>();
            for(int i = 2; i<=n; i++)
            {
                if (n == 1)
                    break;
                if (n % i == 0)
                {
                    n /= i;
                    list.Add(i);
                    i = 1;
                }
            }
            for(int i = 0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
        }
    }
}
