using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class PartialClassAndMethod
    {

    }

    internal partial class BaseClass
    {
         partial void SomeMethod();

        public string SomeProperty { get; set; }
    }


    internal partial class BaseClass
    {
        partial void SomeMethod()
        {
            // Some work here
        }
    }
}
