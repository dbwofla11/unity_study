using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    // 텍스트 RPG Player 클래스 
    public enum PlayerType
    {
        None = 0,
        Knight= 1,
        Ranger = 2,
        Mage = 3,
        Rogue = 4
    }

    class Player_class : Creature
    {
        protected PlayerType type = PlayerType.None;

        protected Player_class(PlayerType type) : base(CreatureType.Player) // 간접적인 접근 방식 아래에 직업을 자식클래스에서 생성
        {
            this.type = type;
        }

        public PlayerType GetPlayerType() { return type;  }
        
    }

    class Knight : Player_class
    {
        public Knight() : base(PlayerType.Knight) // 부모님의 생성자를 상속하는 base
        {
            SetInfo(100, 10);
        }
    }
    class Ranger : Player_class
    {
        public Ranger() : base(PlayerType.Ranger)
        {
            SetInfo(90, 20);
        }
    }
    class Mage : Player_class
    {
        public Mage() : base(PlayerType.Mage)
        {
            SetInfo(80, 30);
        }
    }
    class Rogue : Player_class
    {
        public Rogue() : base(PlayerType.Rogue)
        {
            SetInfo(50, 100);
        }
    }


}
