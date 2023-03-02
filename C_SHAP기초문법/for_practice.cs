using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    internal class for_practice
    {
        static void for_pre()
        {
            // while 문 역시 c언어와 동일 
            int cnt = 1;
            while (cnt <= 5)
            {
                cnt += 1;
                Console.WriteLine("응애5번 출력");
            }

            // do while 문 예제
            string answer; // 유효 변수 선언 , 선언은 위에서 해줘야 오류가 안남 
            do
            {
                Console.WriteLine("나는 잘생겼다고 생각하나? y/n");
                answer = Console.ReadLine(); // 인풋 받는것은 파이썬과 비슷함 단 변수는 미리 선언해야함 
            } while (answer == "n"); // == 비교 연산자는 char형인 ' ' 에서 작동이 안됨 


            // for문 
            for(int i = 1; i <= 5; i++)
            {
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*"); // C# 에서 Write 와 Writeline 은 다름 전자는 옆에 쓰는 것이고 후자는 줄을 바꾸면서 쓰는 거 
                }
                Console.WriteLine("");
            }

        }
            
    }
}
