using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2_P76084300_施逢怡
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data1 = new int[15];
            Random ranObj = new Random();
            int ranNo ;

            //problem 1-1
            for (int i=0 ; i <15; i++)        
            {
                ranNo = ranObj.Next(-100, 100);
                while(IsRepeat(ranNo, data1))
                {
                    ranNo = ranObj.Next(-100, 100);
                }
                data1[i] = ranNo;
            }

            //problem 1-2
            int[] data2 = (int[])data1.Clone();
            Array.Sort(data2);

            //problem 1-3
            int[] data3 = (int[])data2.Clone();
            Array.Reverse(data3);

            //problem 1-4
            int[] data4 = new int[15];
            for(int i=0; i<14; i+=2)
            {
                int j = i / 2;
                data4[i] = data3[j];
                data4[i + 1] = data2[j];
            }
            data4[data4.Length-1] = data3[7];

            //print problem 1 result
            PrintArray(data1,1);
            PrintArray(data2,2);
            PrintArray(data3,3);
            PrintArray(data4,4);
            Console.WriteLine();

            //problem 2
            Console.Write("請輸入本金： ");
            int principal = int.Parse(Console.ReadLine());
            Console.Write("請輸入年利率(%): ");
            double rate = double.Parse(Console.ReadLine());
            rate = rate / 100;
            Console.Write("請輸入存款年數： ");
            int year = int.Parse(Console.ReadLine());

            double result = CompoundInterest(principal, rate, year);
            string solution = (result*principal).ToString("#");     //本金*遞迴的利率結果
            Console.Write("本利和為："+ solution);

            Console.Read();
        }

        //檢查矩陣是否重複,是return true, 否return false
        private static bool IsRepeat(int tmp, int[] arr)
        {
            foreach(var item in arr)
            {
                if(item == tmp)
                {
                    return true;
                }
            }
            return false;
        }

        //print problem 1's solution
        private static void PrintArray(int[] arr, int number)
        {
            Console.Write("{0}: ", number);
            foreach(var item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }

        //calculate the rate(Recursive)
        private static double CompoundInterest(int principal, double rate, int year)
        {
            double result_rate;
            if (year < 1)
                return 1;
            result_rate = (1 + (rate)) * CompoundInterest(principal, rate, year - 1);
            return result_rate;
        }
    }
}
