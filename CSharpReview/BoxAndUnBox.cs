using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class BoxAndUnBox
    {

        public void Box()
        {
            int i = 1;

            object o = i;
        }

        public void UnBox()
        {
            object o = 21;

            int i = (int)o;
        }
    }
}
