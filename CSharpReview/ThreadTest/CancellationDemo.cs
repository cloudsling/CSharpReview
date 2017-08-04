using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharpReview.ThreadTest
{
    class CancellationDemo
    {
        internal static void Test()
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            ThreadPool.QueueUserWorkItem(o => Work(cts.Token, o));

            Console.ReadLine();
            cts.Cancel();
        }

        internal static void Work(CancellationToken cts, Object state)
        {
            for (var i = 0; i < 100; i++)
            {
                if (cts.IsCancellationRequested)
                {
                    Console.WriteLine("Work Cancelled");
                    break;
                }

                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Finish work");
        }
    }
}
