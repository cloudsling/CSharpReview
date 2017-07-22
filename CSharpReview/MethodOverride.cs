using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class MethodOverride
    {

    }

    class BaseClass
    {
        internal void Method1()
        {
            Console.WriteLine("Method of Base");
        }

        internal virtual void Method2()
        {
            Console.WriteLine("virtual Method of base");
        }
    }

    class SubClass : BaseClass
    {
        internal new void Method1()
        {

            Console.WriteLine("Method of Subclass");
        }

        internal override void Method2()
        {
            Console.WriteLine("Instance Method of subclass");
        }
    }
}
