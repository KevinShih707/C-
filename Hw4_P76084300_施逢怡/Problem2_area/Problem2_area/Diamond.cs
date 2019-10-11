using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_area
{
    class Diamond:IShape
    {
        public void Show()
        {
            Console.Write("請輸入高-->");
            double height = double.Parse(Console.ReadLine());
            Console.Write("請輸入底-->");
            double bottom = double.Parse(Console.ReadLine());
            Console.WriteLine("矩形：高 = {0}，底 = {1}，面積為{2}", height, bottom, (height * bottom));
            Console.WriteLine();
        }
    }
}
