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
            int[] data = new int[15];
            Random ranObj = new Random();
            int ranNo ;
            for (int i=0 ; i <15; i++)        
            {
                ranNo = ranObj.Next(-100, 100);
                while(IsRepeat(ranNo, data))
                {
                    ranNo = ranObj.Next(-100, 100);
                }
                data[i] = ranNo;
            }
            PrintArray(data,1);
            Console.Read();
        }

        //檢查是否重複,是return true, 否return false
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

        private static void PrintArray(int[] arr, int number)
        {
            Console.Write("{0}: ", number);
            foreach(var item in arr)
            {
                Console.Write(item+" ");
            }
        }
    }
}
