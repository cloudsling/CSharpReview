using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview.TaskDemo
{
    class TaskBasic
    {
        public static void Test()
        {
            new RunDemo().NewTaskTest();
        }
    }

    internal class RunDemo
    {
        public void NewTaskTest()
        {
            Task<int> t = new Task<int>(Do, null);

            t.Start();

            Parallel.For(0, 10, i => Console.WriteLine($"Main Line: {i}.............."));
            t.ContinueWith(tr => Console.WriteLine($"Task finish with return {tr.Result}"));
        }

        public int Do(Object state)
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($" Line: {i}..............");
            }
            return 100;
        }
    }
}
