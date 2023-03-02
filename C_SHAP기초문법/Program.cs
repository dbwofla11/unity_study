using System;

namespace CShap // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void basic(string[] args) 
        {   // 응애         
            Console.WriteLine("Hello World!");
            
            int a1 = 10; // ID개열 아이템이라든지 이런건 long형 추천한다 함 
            Console.WriteLine("이런포멧도 가능 {0}" ,  a1); // 이런식으로 파이썬처럼 쓸 수 있다. // {} 포멧안에 번호를 넣어 주어야 함 

            string str = "hello world!"; // char에 메모리를 활당하는 방식이 아닌 그냥 쓸수 있다 
            Console.WriteLine(str);


            // 자료변환 
            int a = 1000;
            short b = (short)a;

            float test_a = 1.2345678f;  // 소수를 지정할때 마지막에 f 붙이기 
            int test_b = (int)test_a; // 이런식으로 소수를 정수로 변환 가능
            Console.WriteLine(test_b);

            //string str_a = "123";
            //int int_a = (int)str_a;   // 문자열을 숫자로 바꾸는 것은 불가능함
            //Console.WriteLine(int_a);

        }
    }
}