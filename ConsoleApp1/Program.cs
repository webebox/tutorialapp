using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = new Attributes();

            // Conditional
            a.DebugMethod();

            // Obsolete            
            // Console.WriteLine(a.OldMethod());

            // Custom Attribute
            MethodBase method = typeof(Attributes).GetMethod("CustomMethod");
            CutomAttribute attr = (CutomAttribute)method.GetCustomAttributes(typeof(CutomAttribute), true)[0];
            Console.WriteLine("Developer is : " + attr.Developer);

        }
    }
}