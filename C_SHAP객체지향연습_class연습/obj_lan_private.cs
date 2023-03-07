using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShap
{
    class Knight
    {
        private int id;
        
        public void Setup_id(int id)
        {
            this.id = id;
        }

    }


    class obj_lan_private
    {
        static void Main(string[] args)
        {
            Knight a = new Knight();
            a.Setup_id(1);
            
        }
        
    }
}
