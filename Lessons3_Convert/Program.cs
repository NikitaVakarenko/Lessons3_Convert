using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons3_Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;

            int a, b,c;

            Console.Write("Enter the number1:");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter the number2:");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            int result = a + b;
            Console.WriteLine("The sum is:" + result);


            Console.Write("Enter the double:");
            str = Console.ReadLine();
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double d = Convert.ToDouble(str,numberFormatInfo);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
