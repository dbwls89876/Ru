using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 기타
{
    class _9095_dynamic_1_2_3
    {

        static void func(List<int> list, int n)
        {
            if (list.Count() < n)
            {
                func(list, n - 1);
            }
            list.Add(list[n - 1] + list[n - 2] + list[n - 3]); // list[n-1]+1 = n, list[n-1]+2 = n, list[n-2]+3 = n
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(0);
            list.Add(1); //list[1]
            list.Add(2); // list[2]
            list.Add(4); // list[3]
            int t = int.Parse(Console.ReadLine());

            for(int i = 0; i<t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                

                while(list.Count()<=n)
                    func(list, n);
                Console.WriteLine(list[n]);
            }

        }
    }
}
