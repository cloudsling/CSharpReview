using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.ReviewInterface
{
    class InterfaceReview
    {

        public static void Test()
        {
            SimpleType ty = new SimpleType();
            ty.Dispose();

            IFun fun = new SimpleType();
            fun.Dispose();

            fun = ty;
            fun.Dispose();

            IDisposable dis = ty;
            dis.Dispose();

            Console.Read();
        }
    }

    interface IDisposable
    {
        void Dispose();
    }

    interface IFun
    {
        void Dispose();
    }

    class SimpleType : IDisposable, IFun
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
