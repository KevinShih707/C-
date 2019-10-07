using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3_P76084300_施逢怡
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranObj = new Random();
            int[] data1 = new int[2];
            int ranNo;

            for (int i = 0; i < 2; i++)
            {
                ranNo = ranObj.Next(0, 100);
                while (IsRepeat(ranNo, data1))
                {
                    ranNo = ranObj.Next(0, 100);
                }
                data1[i] = ranNo;
            }

            PrintArray(data1);
            AMath amath = new AMath();
            Console.Write("平均值 ");
            Console.WriteLine(amath.Avg(data1[0], data1[1]));

            BMath bmath = new BMath();
            int[] data2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                ranNo = ranObj.Next(0, 100);
                while (IsRepeat(ranNo, data2))
                {
                    ranNo = ranObj.Next(0, 100);
                }
                data2[i] = ranNo;
            }

            PrintArray(data2);
            Console.Write("平均值 ");
            Console.WriteLine(bmath.Avg(data2));
            Console.Read();
        }

        //檢查矩陣是否重複,是return true, 否return false
        private static bool IsRepeat(int tmp, int[] arr)
        {
            foreach (var item in arr)
            {
                if (item == tmp)
                {
                    return true;
                }
            }
            return false;
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            //Console.WriteLine();
        }
    }
}
