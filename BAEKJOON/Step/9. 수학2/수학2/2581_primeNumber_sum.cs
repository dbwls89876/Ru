using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학2
{
    class _2581_primeNumber_sum
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int min = 0, sum = 0;
            for (int i = m; i <= n; i++)
            {
                if (i == 1)
                        continue;
                
                for (int j = 2; j <= i; j++) {
                    if (j == i)
                    {
                        if (min==0)
                            min = i;
                        sum += i;
                        
                    }
                    else if (i % j == 0)
                        break;
                }
                 
                
            }
            if (sum == 0)
            {
                sum = -1;
                Console.WriteLine(sum);
                return;
            }
            Console.WriteLine(sum);
            Console.WriteLine(min);
        }
    }
}
