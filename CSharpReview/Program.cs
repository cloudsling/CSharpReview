using System;
using System.Runtime.InteropServices;

namespace CSharpReview
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass cla = new MyClass();

            cla.ChangeValue(23);

            Console.Read();
        }
    }

}