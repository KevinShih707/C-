using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p76084300_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            do
            {
                x = 1;
                do
                {
                    Console.Write("{0}*{1}={2} ", y, x, x * y);
                    x++;
                }
                while (x < 10);
                y++;
                Console.WriteLine();
            }
            while (y < 10);
            Console.Read();
        }
    }
}
