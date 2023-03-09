using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    public enum GameStage
    {
        None,
        Lobby,
        Town,
        Field
    }

    class Game_sys
    {
        private GameStage stage = GameStage.Lobby;
        private Player_class player = null;
        private Monster_class monster = null;
        Random rand = new Random();

        public void Process()
        {
            switch (stage)
            {
                case GameStage.Lobby:
                    ProcessLobby();
                    break;
                case GameStage.Town:
                    ProcessTown();
                    break;
                case GameStage.Field:
                    ProcessField();
                    break;
            }
        }

        public void ProcessLobby()
        {
            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] Knight");
            Console.WriteLine("[2] Ranger");
            Console.WriteLine("[3] Mage");
            Console.WriteLine("[4] Rogue");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    player = new Knight();
                    stage = GameStage.Town;
                    break;
                case "2":
                    player = new Ranger();
                    stage = GameStage.Town;
                    break;
                case "3":
                    player = new Mage();
                    stage = GameStage.Town;
                    break;
                case "4":
                    player = new Rogue();
                    stage = GameStage.Town;
                    break;
            }
        }

        public void ProcessTown()
        {
            Console.WriteLine("마을에 입장했습니다");
            Console.WriteLine("[1] 로비로 가기 ");
            Console.WriteLine("[2] 사냥터로 가기");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    stage = GameStage.Lobby;
                    break;
                case "2":
                    stage = GameStage.Field;
                    break;
                
            }
        }
        private void CreateRandomMonster()
        {
            int randValue = rand.Next(0, 3);
            switch (randValue)
            {
                case 0:
                    monster = new Slime();
                    Console.WriteLine("슬라임 등장 !!");
                    break;
                case 1:
                    monster = new Orc();
                    Console.WriteLine("오크 등장 !!");
                    break;
                case 2:
                    monster = new Zombie();
                    Console.WriteLine("좀비 등장 !!");
                    break;

            }
        }

        public void ProcessField()
        {
            Console.WriteLine("필드에 입장했습니다");
            Console.WriteLine("[1] 싸우기");
            Console.WriteLine("[2] 일정 확률로 마을 돌아가기");

            CreateRandomMonster();

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    ProcessFight();
                    break;
                case "2":
                    TryEscape();
                    break;

            }
        }

        private void ProcessFight()
        {
            while (true)
            {
                int damage = player.GetAttack();
                monster.OnDamaged(damage);
                if (monster.isDaed())
                {
                    Console.WriteLine("승리했습니다!!");
                    Console.WriteLine($"플레이어의 남은 체력 {player.GetHp()}");
                    break;
                }

                damage = monster.GetAttack();
                player.OnDamaged(damage);
                if (player.isDaed())
                {
                    Console.WriteLine("죽었습니다!!");
                    Console.WriteLine($"몬스터의 남은 체력 {monster.GetHp()}");
                    break;
                }

                Console.WriteLine($"현재 플레이어의 체력 : {player.GetHp()} , 현재 몬스터의 남은 체력 {monster.GetHp()}");


            }
        }

        private void TryEscape()
        {
            int runvalue = rand.Next(0, 101);
            if (runvalue < 33)
            {
                stage = GameStage.Town;
            }
            else
            {
                ProcessFight();
            }
        }

   

    }
}
