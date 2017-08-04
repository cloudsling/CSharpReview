using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpReview.ThreadTest
{
    class ThreadPoolTest
    {
        internal static void Test()
        {
            Console.WriteLine("Start Test");

            ThreadPool.QueueUserWorkItem(ComputeSomething, 5);
            Console.WriteLine("Doing other work here");

            Thread.Sleep(1000);
        }

        internal static void ComputeSomething(Object state)
        {
            Console.WriteLine("In Computing: state={0}", state);
            Thread.Sleep(1000);
        }
    }
}
