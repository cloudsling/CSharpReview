using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.Delegate
{
    internal class Delegate
    {
        private Func<int, int> _test;
        public void DelegateTest()
        {
            _test += StaticDele.StaticDeleTest;

            StaticDele del = new StaticDele();
            _test += del.DeleTest;

            _test(5);
        }
    }

    public class StaticDele
    {
        public int DeleTest(int i)
        {
            Console.WriteLine(i + 9);
            return i * i;
        }
        public static int StaticDeleTest(int i)
        {
            Console.WriteLine(i + i);
            return i + 9;
        }
    }
}
