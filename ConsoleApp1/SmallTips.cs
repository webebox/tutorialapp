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
        // Initializer
        SmallTips()
        {
            //Initialize Code
        }

        // Finalizer
        ~SmallTips()   // Tip!
        {
            //Dispose Code
        }

        // flags
        [System.Flags]
        public enum Names : int
        {
            Ali = 1,
            Hasan = 2,
            Reza = 3
        }

        // init  Tip!
        public class ImmutablePerson
        {
            public string? FirstName { get; init; }
        }

        public static void Run()
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

            // flags
            // Tip!
            // we can define an enum that has different value
            var ali = Names.Ali;
            Console.WriteLine(ali);  // ali
            Console.WriteLine((int)ali); // 1

            // tuples
            (string, int) fruit = new("apple", 1);

            (string Name, int Weight) animal = new();
            animal.Name = "Lion";
            animal.Weight = 200;

            // Method Parameters
            int x = 1;
            int y = 2;
            int z = 3;

            x = PassingParameters(x, ref y, out z);
            Console.WriteLine($"x:{x}, y:{y}, z:{z}");

            // simplified out parameters Tip!
            int a = PassingParameters(1, ref y, out int w);  // inline
            Console.WriteLine($"w:{w}");

            // Init
            ImmutablePerson ip = new ImmutablePerson() { FirstName = "Ali" };
            //ip.FirstName = "Ali"; // error


        }

        // x :in-only
        // y : in and out Tip!
        // z : out only 
        public static int PassingParameters(int x, ref int y, out int z)
        {
            x = x * 2;
            y = y * 3;
            //z = z * 4;  error
            z = 77777777;

            return x;
        }

    }
}
