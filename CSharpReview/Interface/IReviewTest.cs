using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace CSharpReview.Interface
{
    class IReviewTest
    {

        public void Test()
        {
            SimpleType ty = new SimpleType();
            ty.Dispose();

            IDisposable dis = ty;
            dis.Dispose();

            Console.Read();
        }
    }

    class SimpleType : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Simple type dispose");
        }

        void IDisposable.Dispose()
        {
            Console.WriteLine("Intreface dispose");
        }
    }
}
