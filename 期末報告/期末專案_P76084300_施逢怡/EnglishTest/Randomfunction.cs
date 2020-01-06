using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishTest
{
    public class RandomFunction
    {
        //取得亂數，number為所需個數，maximum為最大值
        public int[] GetRandom(int number, int maximum)
        {
            int max = maximum;
            int min = 1;
            int[] randomArray = new int[number];
            Random randomNumber = new Random();
            for (int i = 0; i < number; i++)
            {
                randomArray[i] = randomNumber.Next(min, max);//亂數產生，亂數產生的範圍是1~number           
                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])//檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;//如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)                               
                        randomArray[i] = randomNumber.Next(min, max);//重新產生，存回陣列，亂數產生的範圍是1~number          
                    }
                }
            }
            return randomArray;
        }
        //回傳index，123 321

        public int[] GetRandom2(int number)
        {
            const int MAX = 4;
            int min = 0;
            int[] randomArray = new int[number];
            Random randomNumber = new Random();
            for (int i = 0; i < number; i++)
            {
                randomArray[i] = randomNumber.Next(min, MAX);//亂數產生，亂數產生的範圍是1~number           
                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])//檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;//如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)                               
                        randomArray[i] = randomNumber.Next(min, MAX);//重新產生，存回陣列，亂數產生的範圍是1~number          
                    }
                }
            }
            return randomArray;
        }

        //錯誤選項的index
        public int[] GetRandom3(int number, int maximum, int answer)
        {
            int max = maximum;
            int min = 1;
            int[] randomArray = new int[number];
            Random randomNumber = new Random();
            for (int i = 0; i < number; i++)
            {
                randomArray[i] = randomNumber.Next(min, max);//亂數產生，亂數產生的範圍是1~number           
                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i] || randomArray[i] == answer)//檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;//如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)                               
                        randomArray[i] = randomNumber.Next(min, max);//重新產生，存回陣列，亂數產生的範圍是1~number          
                    }
                }
            }
            return randomArray;
        }

        //顯示填充題題號
        public string ShowType(bool noQuestion, int counter)
        {
            const string QUESTION = "Q";
            const string FILL = ":Fill in the Blanks";
            string title = QUESTION + (++counter) + FILL;
            if (noQuestion)
                return string.Empty;
            return title;
        }

        //顯示選擇題題號
        public string ShowType2(bool noQuestion, int counter)
        {
            const string QUESTION = "Q";
            const string MULTIPLE = ":Multiple Choice Question";
            string title = QUESTION + (++counter) + MULTIPLE;
            if (noQuestion)
                return string.Empty;
            return title;
        }
    }
}
