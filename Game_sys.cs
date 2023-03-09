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
    }
}
