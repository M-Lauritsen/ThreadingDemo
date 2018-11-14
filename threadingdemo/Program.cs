using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadingdemo
{
    class Program
    {


        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);  // start a new thread
            t.Start();                      // Run WriteY()

            new Thread(Go).Start();         // Start a new Thread
            Go();                           // Call Go() on the main thread

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("x");
            }
        }

        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++)
            {
                // Decalre and use a Local variable - 'cycles'
                Console.Write("?");
            }
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("y");
            }

            Console.ReadKey();
        }

        
        
    }
}
