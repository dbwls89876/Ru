using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 수학2
{
    class _4948_Bertrand_s_postulate
    {
        static void Main(string[] args)
        {


            int n = 1;
            int result, check;
            StringBuilder sb = new StringBuilder();
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            while (true) // 배열에 있는 값 확인 후 있으면 계산 x
            {
                n = int.Parse(Console.ReadLine());
                result = 0;
                if (n == 0)
                    break;
                if (list.Last() < n*2) // 리스트의 마지막 값이 2n보다 작을 때
                {
                    for(int i = 0; i<list.Count(); i++)//마지막 리스트의 값까지 확인해보기
                    {
                        if (list[i] > n) // n보다 클때 result의 값 증가, list의 마지막 값은 n보다 작을수도 있음
                            result++;
                    }
                    
                    for (int i = list.Last()+1; i<=n*2; i++) // 리스트의 마지막 값 +1부터(마지막 값은 소수기 때문에 중복 추가 방지) 소수 추가 시작, 2n보다 작아질 때 까지
                    {
                        check = 0; // 소수가 아닌지 확인
                        for(int j = 0; j < list.Count(); j++) // 리스트의 갯수만큼 확인
                        {
                            if (i % list[j] == 0) // i를 소수로 나눴을때 0으로 나누어 떨어진다면
                            {
                                check = 1; // 소수가 아닌것으로 판명
                                break;
                            }
                            else if (list[j] > i / list[j]) // 소수의 크기 > 값 / 소수의 크기 일 때 그 이상으로 나눌 의미가 없음
                                break;
                        }
                        if (check == 0) // check가 0이라면 새로운 소수 값 추가
                        {
                            list.Add(i);
                            if (list.Last() > n) // list의 마지막 값이 n보다 큰지 확인, 클 경우 result의 값 증가
                                result++;
                        }
                    }
                }
                else
                {
                    for(int i = 0; list[i]<=n*2; i++) // i = 리스트의 마지막 인덱스 
                    {   
                        if(list[i]>n) // list의 값이 n보다 클 때 result의 값 추가
                            result++;
                    }
                }                
                Console.WriteLine(result); // 값 출력
            }

        }
    }
}
