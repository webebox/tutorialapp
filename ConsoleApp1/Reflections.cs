using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Reflection objects are used for obtaining type information at runtime.
    internal class Reflections
    {

        public static void Run()
        {
            // Reflection
            System.Reflection.MemberInfo info = typeof(Attributes);
            Console.WriteLine("Name is : " + info.Name);
        }


    }
}
