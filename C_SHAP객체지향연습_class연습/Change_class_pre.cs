using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    /*class Player
    {
        protected int hp;
        protected int attack;
    }
    class Kisa : Player
    {
        public int dpence;
    }*/
    /*class Mage : Player
    {
        public int mp;
    }*/

    class Change_class_pre
    {

        /*static void EnterGame(Player p) // 부모클래스로 받기 
        {
            bool isMage = (p is Mage); // 클래스를 부모로 받고 마법사일때 마나를 설정하는것 
            bool isKisa = (p is Kisa);
            if (isMage)
            {
                Mage mage = (Mage)p;
                mage.mp = 100000;
            } else if (isKisa)
            {
                Kisa kisa = (Kisa)p;
                kisa.dpence = 1000;
            }
        }*/

        /*static void Main(string[] args)
        {
            Kisa kisa = new Kisa();*/
            //Mage mage = new Mage(); // 클래스의 타입 변환은 자유전직과 같다  ( 자식 -> 부모 ) 0 ( 부모 -> 자식 ) x ( 자식 -> 자식 ) x 

            /*EnterGame(kisa);
            EnterGame(mage);*/
        }
    }
}
