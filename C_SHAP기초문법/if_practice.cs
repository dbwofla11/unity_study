using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    internal class if_practice
    {
        static void Main(string[] args)
        {
            // 사람 만들어서 피깍은 다음 죽었습니다 메시지 띄우기 
            int hp = -1;
            bool isDaed = (hp <= 0); // 이런식으로 조건은 분리해서 따로 빼면 클린코드가 됨 

            // if , elif , else는 c언어와 문법이 같음 
            if (isDaed) Console.WriteLine("죽었습니다");
            else Console.WriteLine("당신은 살았습니다");

            // switch case문 --> 이 역시 c언어와 같음  
            /*int choice = 0;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
            }*/

            Random rand = new Random(); // 랜덤 숫자 생성 
            int ai_choice = rand.Next(0, 3); // 0 ~ 2 사이 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine()); // c# 에서 입력값 받기 readline이 받는거 writeline이 출력하는거
            switch (choice)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
            }

            // 클린코드 팁 -> 그냥 숫자를 비교할때는 열거형과 상수형을 써서 비교하면 좋다.
            // 상수형
            const int Rock = 1;
            const int Paper = 2;
            const int Scissors = 0;
            // 상수형으로 지정하는 것은 단순 변수와 그냥 숫자를 비교하는 것 보다 가독성이 좋아지기 때문이다. 


            // 열거형 
            enum Choice
            { 
                rock = 1,
                paper = 2,
                scissors = 0
            }
            // 열거형을 쓸때는 (int)열거목록.열거항목 이런식으로 쓸 수 있는데 rock을 꺼내고 싶다하면 (int)Choice.rock




        }
    }
}
