using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class ExtensionMethod
    {
    }

    public static class MyStringBuilderExtensions
    {
        public static Int32 IndexOf(this StringBuilder sb, Char value)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
    }


    public static class InterfaceExtensions
    {
        public static void ShowItems<T>(this IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
