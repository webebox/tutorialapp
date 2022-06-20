using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    // An indexer allows an object to be indexed such as an array
    public class Indexers
    {

        // Declare an array to store the data elements.
        private int[] intArray = new int[100];

        // Define the indexer to allow client code to use [] notation.
        public int this[int i]
        {
            get { return intArray[i] * 10; }
            set { intArray[i] = value; }
        }

        public static void Run()
        {
            // Indexer
            var indexer = new Indexers();
            indexer[1] = 10;
            indexer[2] = 20;
            Console.WriteLine(indexer[2]);
        }

    }
}
