using System;
using System.Runtime.InteropServices;
using CSharpReview.CustomAttribute;
using CSharpReview.ReflectionTest;
using CSharpReview.ReviewInterface;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass cla = new MyClass();
            //cla.ChangeValue(23);

            //BaseClass cls = new SubClass();
            //cls.Method1();
            //cls.Method2();

            //OperatorOverride oper1 = new OperatorOverride { Id = 12, Tag = 32, Name = "Ling" };
            //OperatorOverride oper2 = new OperatorOverride { Id = 12, Tag = 32, Name = "Ling" };
            //var obj = oper2 + oper1;
            //Console.WriteLine(obj.Name + obj.Tag);

            //DateTime dt = default(DateTime);
            //Console.WriteLine(dt);

            //int a = 1, b = 3;
            //Console.WriteLine("a={0},b={1}", a, b);
            //a = b + (b = a) * 0;
            //Console.WriteLine("a={0},b={1}", a, b);
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine("a={0},b={1}", a, b);

            //InterfaceReview.Test();

            //Delegate.Delegate del = new Delegate.Delegate();
            //del.DelegateTest();

            //AttributeTest.Test();

            //new ExceptionTest.ExceptionTest().Test();

            // 17.7.31.打卡

            //ReflectionTest.ReflectionTest.Test(new TargetObject(120, "Admin"));

            //ThreadTest.ThreadSample.Test();

            //ThreadTest.ThreadPoolTest.Test();
            ThreadTest.CancellationDemo.Test();

            Console.WriteLine("End.............................");
            Console.Read();
        }
    }

}