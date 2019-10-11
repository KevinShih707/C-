using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_player
{
    class EXIT : Player
    {
        public override void display()      
        {
            Console.WriteLine("要結束時，請按q 或Q 離開...");
        }
    }
}
