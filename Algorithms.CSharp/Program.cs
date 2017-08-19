using System;
using System.Collections.Generic;
using Algorithms.CSharp.Sort;

namespace Algorithms.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int> { 61, 3, 4, 5, 34, 23, 12, 76, 36, 24, 95, 32, 76, 23, 08, 345, 34, 12, 95, 54, 54, 43, 27, 74 };
            var qc = new QuickSort<int>(ls);

            qc.Sort();
            var lst = qc.List;

            Console.Read();
        }
    }
}