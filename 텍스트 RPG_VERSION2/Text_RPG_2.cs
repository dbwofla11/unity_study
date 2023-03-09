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
            Game_sys game = new Game_sys();

            while (true)
            {
                game.Process();
            }
        }

    }
}
