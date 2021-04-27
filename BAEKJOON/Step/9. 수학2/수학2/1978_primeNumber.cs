using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학2
{
    class _1978_primeNumber
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            for (int i = 0; i < n; i++){
                int p = int.Parse(arr[i]);
                if (p == 1)
                    continue;
                
                for(int j = 2; j<=p; j++)
                {
                    if (j == p)
                    {
                        result++;
                        break;
                    }
                    else if (p % j == 0)
                        break;
                }  
            }
            Console.WriteLine(result);
        }
    }
}
