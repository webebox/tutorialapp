using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Task.CompletedTask;

            // uncomment and watch the intellisense in below code
            // DocumentattionComments.Add

            //RuntimeDebug.Run();

            // SmallTips.Run();

            // events
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();

            // eventhandler
            ProcessBusinessLogic2 bl2 = new ProcessBusinessLogic2();
            bl2.ProcessCompleted += bl2_ProcessCompleted; // register with an event
            bl2.StartProcess();

            // checked
            var check = new Checked();
            check.Run();

        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }

        public static void bl2_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime);
        }

    }
}