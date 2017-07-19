using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class MyClass
    {
        private readonly Test _testVal;

        private readonly string _someInt = "dsdfadfa";

        public MyClass()
        {
            _testVal = new Test();
            // _someInt = "dsdsdsds";
        }

        public void ChangeValue(int test)
        {
            _testVal.Val = test;
            Console.WriteLine(_testVal.Val);


            Console.WriteLine(_someInt);
        }



    }
}
