using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class RuntimeDebug
    {

        public static void Run()
        {
            // Debug : only while debgging
            // Trace : debug and release


            // Be sure run the application in Debug Mode by press F5
            // in output window select debug to see the debug messages
            // Only in Debug Mode
            Debug.WriteLine("this is debug message");
            Trace.WriteLine("this is trace message");

            // Always Executes
            // write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(
            File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt"))));
          
            // text writer is buffered, so this option calls
            // Flush() on all listeners after writing
            Trace.AutoFlush = true;
            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

        }

    }
}
