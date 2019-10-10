using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_player
{
    class CD : Player
    {
        public override void display()       // 允許被子類別覆寫
        {
            Console.WriteLine("現在播放的是 音樂 CD");
        }
    }
}
