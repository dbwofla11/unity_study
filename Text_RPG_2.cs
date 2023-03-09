using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CShap
{
    

    class Text_RPG_2
    {
        public static void Main(string[] args)
        {
           

            // 딱히 include  , import 같은게 필요없음 
            Player_class player = new Knight();
            Monster_class monster = new Zombie();

            int damage = player.GetAttack();
            monster.OnDamaged(damage);

            Console.WriteLine(monster.GetHp());
        }

    }
}
