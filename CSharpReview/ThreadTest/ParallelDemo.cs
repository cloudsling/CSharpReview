using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CSharpReview.ThreadTest
{
    class ParallelDemo
    {
        public void ParallelInvoke()
        {
            Parallel.Invoke(
                () => DoSomething(0),
                () => DoSomething(0),
                () => DoSomething(0));
        }

        public void DoWithParallel()
        {
            Parallel.For(0, 1000, DoSomething);
        }

        public void DoWithFor()
        {
            for (int i = 0; i < 1000; i++)
            {
                DoSomething(i);
            }
        }

        public void DoSomething(int index)
        {
            // Do something
        }
    }
}
