using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Checked
    {

        public void Run()
        {
            int n = int.MaxValue;
            Console.WriteLine("n : " + n);

            checked
            {
                Console.WriteLine("checked : " + (n + 10));  // ignores and not show error
            }
            unchecked
            {
                Console.WriteLine("unchecked : " + (n + 10));  // shows error becase it is unchecked and overflow
            }


        }

    }
}
