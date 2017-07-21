using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class BoxAndUnBox
    {
        // 三次装箱
        public void Box()
        {
            int i = 1;

            Console.WriteLine("{0}, {1}, {2}", i, i, i);
        }
        // 一次装箱
        public void UnBox()
        {
            int i = 21;
            object o = i;

            Console.WriteLine("{0}, {1}, {2}", o, o, o);
        }
    }
}
