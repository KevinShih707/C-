using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3_P76084300_施逢怡
{
    class BMath:AMath
    {
        public double Avg(int[] input)
        {
            double total=0;
            for(int i =0;i<input.Length;i++)
            {
                total += input[i];
            }
            return ((total) / input.Length);
        }
    }
}
