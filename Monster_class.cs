using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    public enum MonsterType
    {
        None = 0,
        Slime = 1,
        Orc = 2,
        Zombie = 3
    }
    class Monster_class : Creature
    {
        protected MonsterType type = MonsterType.None;
        protected Monster_class(MonsterType type) : base(CreatureType.Player)
        {
            this.type = type;
        }
        public MonsterType GetMonsterType() { return type; }
    }

    class Slime : Monster_class
    {
        public Slime() : base(MonsterType.Slime)
        {
            SetInfo(100, 1);
        }
    }
    class Orc : Monster_class
    {
        public Orc() : base(MonsterType.Orc)
        {
            SetInfo(90, 3);
        }
    }
    class Zombie : Monster_class
    {
        public Zombie() : base(MonsterType.Zombie)
        {
            SetInfo(80, 5);
        }
    }
}
