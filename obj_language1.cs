using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace CShap
{
    // 객체 ( 코드나 엔티티 스킬 같은것도 다 객체로 만들어 보기 ) // 객체를 묘사하는 방법 
    // 객체는 속성과 기능을 나눠서 구현을 할 수 있음 
    public class Knight // 전사의 객체 설계도 ( 클래스 )
    {
        static public int id_cnt = 1; // 아이디 만들때 static 사용 

        public int id;
        public int hp;
        public int attack;

        // 생성자 - 기사 
        public Knight()
        {
            id = id_cnt;
            id_cnt++;

            hp = 10;
            attack = 1000;
            Console.WriteLine("생성자 호출 ");
        }

        // 생성자 - 기사 + 변수가 들어가 조작되는 생성자 
        public Knight(int hp) : this()
        {
            this.hp = hp; // 위의 클래스에 Wls hp에 변수를 불러오겠다는 마인드 
            // 공격력은 위에 껄로 들어감 
            Console.WriteLine("변수 생성자 호출 ");
        }

        // 기사 복사본 만들기 ( deep copy )
        public Knight Clone()
        {
            Knight knight = new Knight(); // 기사 2 객체 - 복사본 만들기 
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine($"기사가 움직였습니다{hp} , {attack}");
        }
        public void Attack()
        {
            Console.WriteLine($"기사가 공격햇습니다 {hp} , {attack}");
        }

    } 
    // 클래스는 참조자를 해서 찐 데이터를 전달함 // 본체 변수에 전달이 됨 
    // 반대로 구조체는 값만 복사함 ( C언어가 절차지향적인 언어인 이유임 ) // 구조체는 ref를 써야지 본체가 변형이 됨 


    public class obj_language1
    { 
        
        static void Main(string[] args)
        {
            Knight knight = new Knight(); // 기사를 여러명 만들려면 new를 한번 더해서 만들면 됨  // 기사 1 객체 + < 생성자 작동 - 위에서 객체 정의 > 
            Console.WriteLine(knight.hp); // 10

            Knight knight2 = knight.Clone(); // clone 을 해도 같은 객체를 불러와 복제하는 거여서 ( 생성자 호출 )
            knight2.hp = 0; //  clone = deep copy
            Console.WriteLine(knight2.hp);

            Knight knight3 = new Knight(30); // 공격력과 체력이 30인 기사 - 생성자 사용 
            Console.WriteLine($"{knight3.hp} ,  {knight3.attack}");

            
            
        }
    }
}
