using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 함수 만들어 보기 
namespace CShap
{
    internal class function_pre
    {


        // 반환이 없는 것 
        static void hello_world()
        {
            string tt = "안녕하세여";
            Console.WriteLine($"hello world{tt}");
        }


        // 반환이 있는 것 
        static int add(int a , int b)
        {
            int result = a + b;
            return result;
        }


        // ref 변수 참조 
        static void addone(ref int num)
        {
            num += 10;
        } // 이런식으로 변수내의 값만 변환 가능 변수는 같으나 값만 더해지는 것 


        static void swap(ref int a , ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }


        static void out_test(int a , int b , out int result1 , out int result2)
        {
            result1 = a + 1000; 
            result2 = b + 10;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("cw tap tap 누르면 이게 나옴 ");
            
            hello_world(); // 함수 불러오기 -> 이런식으로 앞에 클래스를 생략해도 됨 
            
            int r = function_pre.add(2, 3);
            Console.WriteLine( r ); // 이런식으로 클래스를 앞에 붙여도 됨  
            // 이런식으로 하는 것은 짝퉁 

            int a = 10;
            addone(ref a);
            Console.WriteLine(a);
            // 이런식으로 하는 것은 진짜 


            // ref로 함수를 쓰는 것은 이렇게 활용 가능함 
            int num1 = 10;
            int num2 = 0;
            function_pre.swap(ref num1, ref num2);
            Console.WriteLine($"num1 : {num1} num2:{num2}");
            // ref 를 쓰는 이유는 그냥 함수는 return을 하면 하나밖에 반환을 못하기 때문에 여러개 반환할때 쓴다고 함 


            int r1;
            int r2;
            function_pre.out_test(10 , 10 , out r1 , out r2);
            Console.WriteLine($"r1 r2 출력 ㅣ {r1} , {r2}");

        }






    }
}
