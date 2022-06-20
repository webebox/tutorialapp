#define DEBUG

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Attributes
    {

        // Conditional
        [Conditional("DEBUG")]  // this method runs only in Debug mode
        public void DebugMethod()
        {
            Console.WriteLine("Debug Method");
        }

        // Obsolete
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public string OldMethod()
        {
            return "old";
        }

        // Custom Attribute Setting Value
        [CutomAttribute(56, "Zara Ali", "19/10/2012")]
        public void CustomMethod()
        {

        }

        public static void Run()
        {
            var a = new Attributes();

            // Conditional
            a.DebugMethod();

            // Obsolete            
            // Console.WriteLine(a.OldMethod());

            Console.WriteLine("----------------------");

            // Custom Attribute
            MethodBase method = typeof(Attributes).GetMethod("CustomMethod");
            CutomAttribute attr = (CutomAttribute)method.GetCustomAttributes(typeof(CutomAttribute), true)[0];
            Console.WriteLine("Developer is : " + attr.Developer);

        }

    }

    // Custom Attribute Declaration
    [AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]
    public class CutomAttribute : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastReview;

        public CutomAttribute(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastReview = d;
        }
        public int BugNo => bugNo;
        public string Developer => developer;
        public string LastReview => lastReview;
    }

}
