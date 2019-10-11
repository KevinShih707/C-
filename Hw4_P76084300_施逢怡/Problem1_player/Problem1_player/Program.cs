using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_player
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD();
            DVD dvd = new DVD();
            EXIT exit = new EXIT();

            while (true)
            {
                Console.Write("請輸入放入的光碟(CD 或DVD) : ");
                string input = Console.ReadLine();

                if (input == "cd" || input == "CD")
                {
                    cd.display();
                }

                else if (input == "dvd" || input == "DVD")
                {
                    dvd.display();
                }

                else if (input == "exit" || input == "EXIT" || input == "W" || input == "w")
                {
                    exit.display();
                    break;
                }
                else
                    Console.WriteLine("請重新輸入");
            }
                
            Console.Read();
        }
    }
}
