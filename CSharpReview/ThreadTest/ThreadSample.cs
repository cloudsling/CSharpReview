using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpReview.ThreadTest
{
    class ThreadSample
    {
        internal static void Test()
        {
            Thread th = new Thread(Worker);

            th.IsBackground = true;
            th.Start();

            Console.WriteLine("Returning form test");
        }

        internal static void Worker()
        {
            Thread.Sleep(3000);

            Console.WriteLine("Returning from worker");
        }
    }
}
