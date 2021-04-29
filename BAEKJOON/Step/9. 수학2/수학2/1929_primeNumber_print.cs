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
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');
            int m = int.Parse(arr[0]);
            int n = int.Parse(arr[1]);
            int check;
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>();
            for (int i = 2; i <= n; i++) // i를 2, 3, 4... n%로 나누기
            {
                check = 0;
                if (i == 1)
                    continue;

                for (int j = 0; j<list.Count(); j++)
                {
                    //Console.WriteLine(j);
                    if (i % list[j] == 0)
                    {
                        check = 1;
                        break;
                    }
                    else if (list[j] > i / list[j]) // 소수의 크기 > 값 / 소수의 크기 일 때 그 이상으로 나눌 의미가 없음
                        break;
                }
                if (check == 0) {
                    list.Add(i);
                    if(i >= m)
                        sb.Append(i).Append("\n");
                }
            }
            Console.WriteLine(sb);
        }
    }
}
