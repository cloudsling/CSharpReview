using System;
using System.Runtime.InteropServices;

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

            OperatorOverride oper1 = new OperatorOverride { Id = 12, Tag = 32, Name = "Ling" };
            OperatorOverride oper2 = new OperatorOverride { Id = 12, Tag = 32, Name = "Ling" };
            var obj = oper2 + oper1;
            Console.WriteLine(obj.Name + obj.Tag);


            Console.Read();
        }
    }

}