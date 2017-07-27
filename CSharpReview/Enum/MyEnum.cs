using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.Enum
{
    internal enum MyEnum : byte
    {
        White = 0,
        Red,
        Yellow,
        Green,
        Blue
    }

    class EnumTest
    {
        public static void Test()
        {
            var arr = System.Enum.GetValues(typeof(MyEnum));

            var arr2 = GetEnumValues<MyEnum>();
        }

        public static TEnum[] GetEnumValues<TEnum>() where TEnum : struct
        {
            return (TEnum[])System.Enum.GetValues(typeof(TEnum));
        }
    }
}
