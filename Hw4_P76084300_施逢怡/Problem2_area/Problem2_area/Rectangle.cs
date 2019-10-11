using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_area
{
    class Rectangle : IShape
    {
        public void Show()
        {
            Console.Write("請輸入長-->");
            double length = double.Parse(Console.ReadLine());
            Console.Write("請輸入寬-->");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("矩形：長 = {0}，寬 = {1}，面積為{2}", length, width, (length * width));
            Console.WriteLine();
        }
    }
}
