using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학2
{
    class _9020_Goldbach_conjecture
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            
            List<int> list = new List<int>();
            for (int i = 2; i <= 10000; i++) // i를 2, 3, 4... n%로 나누기
            {
                int check = 0;
                for (int j = 0; j < list.Count(); j++)
                {
                    if (i % list[j] == 0)
                    {
                        check = 1;
                        break;
                    }
                    else if (list[j] > i / list[j]) // 소수의 크기 > 값 / 소수의 크기 일 때 그 이상으로 나눌 의미가 없음
                        break;
                }
                if (check == 0)
                {
                    list.Add(i);
                }
            }

            for (int i = 0; i<t; i++)
            {
                int min = 0, max = 0;
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; n/2 >= list[j]; j++){ // n의 중간값 찾기
                    min = j;
                }

                while (true) // max 값을 찾지 못했을 때 min의 값을 감소
                {
                    for(int j = min; list[min] + list[j]<=n; j++) //  list[min]보다 같거나 큰 값이 과 작거나 일치할 때 까지 j값 증가
                    {
                        max = j; //비교를 위해 j값을 max로 넣음
                        if (list[min] + list[max] == n) // list[min]과 list[max]를 합한 값이 n과 일치하는지 확인
                            break;
                    }
                    if (list[min] + list[max] == n) // 한번 더 확인 <<못없애나??, 찾아보자...
                        break;
                    min--;
                    
                }
                Console.WriteLine("{0} {1}", list[min], list[max]);
            }
        }
    }
}
