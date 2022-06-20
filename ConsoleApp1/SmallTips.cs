using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// global using System.Text;
// using static System.Console;

namespace ConsoleApp1
{
    public class SmallTips
    {
        public static void Run(int x)
        {
            int number1 = 1_000_000;
            int number2 = 1_00_00;

            decimal number3 = 0.1M;

            // Object is useful when we don't have more information about the data type
            object obj1 = new();
            object obj2 = 100.543;
            object obj3 = "ali";
            string str1 = obj3.ToString();  // casting

            // Dynamic is useful when we need to code using reflection or dynamic languages or with the COM objects and when getting result out of the LinQ queries.
            dynamic dyn1 = 1.232;
            dynamic dyn2 = "ali";
            string str2 = dyn2;  // no casting

            // default value
            int number4 = default(int);  // 0

            // maxlength
            int number5 = int.MaxValue; // 2,147,483,647

            // format string
            string str3 = string.Format("{0:D}", DateTime.Now);

            // type of
            Type type = typeof(int);


        }
    }
}
