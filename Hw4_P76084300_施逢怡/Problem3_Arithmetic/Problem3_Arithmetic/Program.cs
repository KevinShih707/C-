using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Arithmetic
{
    delegate double Dmath(double x, double y);
    class Program
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            return x / y;
        }
        public static double Calculate(double x, double y, Dmath dv)
        {
            return dv(x, y);
        }
        static void Main(string[] args)
        {
            Dmath add;
            add = new Dmath(Add);
            Dmath subtract;
            subtract = new Dmath(Subtract);
            Dmath multiply;
            multiply = new Dmath(Multiply);
            Dmath divide;
            divide = new Dmath(Divide);

            Console.WriteLine(" 10 + 3 * 2 - 5");
            Console.WriteLine("=10 + {0} - 5", Calculate(3,2, new Dmath(Multiply)));
            Console.WriteLine("={0} - 5", Calculate(10, Calculate(3, 2, new Dmath(Multiply)), new Dmath(Add)));
            Console.WriteLine("={0}", Calculate(Calculate(10, Calculate(3, 2, new Dmath(Multiply)), new Dmath(Add)), 5, new Dmath(Subtract)));

            Console.Read();
        }
    }
}
