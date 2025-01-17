﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

// TEXT RPG 만들어 보기 
namespace CShap
{
    internal class Text_RPG
    {
             
        public static void db_conn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Port=3300;Database=trpg;Uid=root;Pwd=m8161516")) 
            {
                try//예외 처리
                {
                    connection.Open();
                    string sql = "SELECT * FROM trpg_monster";
 
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    MySqlDataReader table = cmd.ExecuteReader();

                    while (table.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", table["id"], table["monster_name"], table["monster_hp"] , table["monster_attack"]);
                    }
                    table.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public static void select_monster()
        {
            
        }

        struct Player // 구조체 사용해서 플레이어 만들기 => 구조체 사용법은 c언어와 같음 
        {
            public int hp;
            public int attack;
            Class_abillity type;
        }

        enum Class_abillity
        {
            None = 0 ,
            Knight = 1,
            Archer = 2,
            Mage = 3 , 
            Rogue = 4,
            hidden = 5
        }

        static Class_abillity Choose_Class()
        {
            Console.WriteLine("~~~~~~~~~~~~직업을 선택하세요!!!~~~~~~~~~~~~");
            Console.WriteLine("[1]-전사");
            Console.WriteLine("[2]-궁수");
            Console.WriteLine("[3]-마법사");
            Console.WriteLine("[4]-도적");
     

            string input = Console.ReadLine();
            Class_abillity choice = Class_abillity.None;
            if (input == "1") choice = Class_abillity.Knight;
            else if (input == "2") choice = Class_abillity.Archer;
            else if (input == "3") choice = Class_abillity.Mage;
            else if (input == "4") choice = Class_abillity.Rogue;
            else if (input == "5") choice = Class_abillity.hidden;
            else choice = Class_abillity.None;

            return choice;
        }

        static void generate_player( Class_abillity choice , out int hp , out int attack)
        {
            hp = 0;
            attack = 0;
            switch (choice)
            {
                case Class_abillity.Knight:
                    hp = 1000;
                    attack = 50;
                    break;
                case Class_abillity.Archer:
                    hp = 200;
                    attack = 250;
                    break;
                case Class_abillity.Mage:
                    hp = 170;
                    attack = 260;
                    break;
                case Class_abillity.Rogue:
                    hp = 335;
                    attack = 200;
                    break;
                case Class_abillity.hidden:
                    hp = 50;
                    attack = 1000;
                    break;
                default:
                    hp = 100;
                    attack = 10;
                    break;
            }

        }

        static void Main(string[] args)
        {
            Class_abillity 직업;
            Player player;

            while (true)
            {
                직업 = Text_RPG.Choose_Class();
                if (직업 != Class_abillity.None) break; 
            }
            Console.Clear();

            // 캐릭터 생성 및 캐릭터 정보창 -> 함수로 빼서 커맨드 입력하면 들어가게끔 만들기 
            Console.WriteLine("================================================");
            Console.WriteLine($"당신이 선택한 직업은 {직업}입니다.");
            generate_player( 직업 , out player.hp, out player.attack);
            Console.WriteLine($"당신의 체력은 {player.hp}이며 공격력은{player.attack}입니다");

            // 여기서 바로 지워지는데 공백하나 받아야 될듯 

            Console.WriteLine("================================================");
            
            // db 연결 
            db_conn();




        }
    }
}
*/