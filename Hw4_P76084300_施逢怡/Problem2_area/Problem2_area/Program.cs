using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_area
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape =null;
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Diamond diamond = new Diamond();
            Parallelogram parallelogram = new Parallelogram();

            while (true)
            {
                Console.Write("請選擇形狀（1.三角形 2.矩形 3.菱形 4.平行四邊形 0.離開）--> ");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    shape = triangle;
                }
                else if (input == "2")
                {
                    shape = rectangle;
                }
                else if (input == "3")
                {
                    shape = diamond;
                }
                else if (input == "4")
                {
                    shape = parallelogram;
                }
                else if(input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("請重新輸入");
                    continue;
                }
                shape.Show();
            }
            Console.Write("確定離開?(Enter)");
            Console.Read();
        }
    }
}
