using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    // 클래스 : 상속성
    // 클래스 - 부모클래스
    public class player
    {
        // 필드 
        static public int cnt = 1; // 오로지 한개만 존재 
        public int id;
        public int hp;
        public int attack;

        public player()
        {
            Console.WriteLine("플래이어 생성자 호출");
        }

    }
    // 클래스 - 자식클래스 
    public class rogue : player
    {
        
    }
    public class Mage : player
    {
        
    }
    public class Kisa : player 
    {
        Kisa()
        {
            Console.WriteLine("기사 생성자 호출");
        }
    }

    public class obj_language2
    {
        public static void Main()
        {

        } 

    }
}
