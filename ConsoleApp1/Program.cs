using System;
using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var a = new Attributes();

            // Conditional
            a.DebugMethod();

            Console.WriteLine("----------------------");

            // Obsolete            
            // Console.WriteLine(a.OldMethod());

            Console.WriteLine("----------------------");

            // Custom Attribute
            MethodBase method = typeof(Attributes).GetMethod("CustomMethod");
            CutomAttribute attr = (CutomAttribute)method.GetCustomAttributes(typeof(CutomAttribute), true)[0];
            Console.WriteLine("Developer is : " + attr.Developer);

            Console.WriteLine("----------------------");

            // Reflection
            System.Reflection.MemberInfo info = typeof(Attributes);
            Console.WriteLine("Name is : " + info.Name);

            Console.WriteLine("----------------------");

            // Indexer
            var indexer = new Indexers();
            indexer[1] = 10;
            indexer[2] = 20;
            Console.WriteLine(indexer[2]);

            Console.WriteLine("----------------------");

            // Async 
            // Asynchronous programming is about the asynchronous sequence of Tasks
            // Async programming is about non-blocking execution between functions
            // Asynchronous is about tasks.
            await Asyncs.ExecuteAsyncFunctions();

            Console.WriteLine("----------------------");

            // Multitreading
            // multithreading is about multiple threads running in parallel
            // We can clearly see the execution of multithreaded methods on different threads as expected.
            // But also, they are keeping the same threads for the continuation compared to the async methods.
            // multithreading programming is all about concurrent execution of different functions
            // Multithreading is about workers
            Multithreadings multithreading = new Multithreadings();
            multithreading.ExecuteMultithreading();

        }
    }
}