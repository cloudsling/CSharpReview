using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class BasicType
    {
        public void Test()
        {
            Console.WriteLine(DynamicInvoke(1, 54));
        }

        public dynamic DynamicInvoke(dynamic i1, dynamic i2)
        {
            return i1 + i2;
        }
    }
}
