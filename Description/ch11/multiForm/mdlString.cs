using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiForm
{
    class mdlString
    {
        public static string stInput;     // 專案範圍公用變數

        public static string ClsSpace(string st)   // 專案範圍公用方法
        {
            string sr = "";
            int len;
            len = st.Length;
            for (int i = 0; i < len; i++)
            {
                string si = st.Substring(i, 1);
                if (! si.Equals(" ")) sr += si;
            }
            return sr;
        }
    
        public static string InverString(string st)   // 專案範圍公用方法
        {
            string inverSt = "";
            int len;
            len = st.Length;
            for (int i = len - 1; i >= 0; i--)
                inverSt += st.Substring(i, 1);
            return inverSt;
        }
    }
}
