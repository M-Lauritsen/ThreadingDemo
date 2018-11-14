using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace threadingdemo
{
    class ThreadTest
    {
        bool done;

        static void main()
        {
            ThreadTest tt = new ThreadTest();           // Create a common instance
            new Thread(tt.Go).Start();
            tt.Go();

        }

        void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }
        }
    }
}
