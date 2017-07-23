using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace CSharpReview
{
    class RotationalOperator
    {
        public static void Test()
        {
            Ratational r = new Ratational(32);

            Ratational r2 = 21;

            float f = (float)r2;
        }
    }

    class Ratational
    {
        public Ratational(Int32 num) { }

        public Ratational(Single num) { }

        public int ToInt32() => 0;

        public Single ToSingle() => 0f;

        public static implicit operator Ratational(Int32 num) => new Ratational(num);

        public static implicit operator Ratational(Single num) => new Ratational(num);

        public static explicit operator Int32(Ratational r) => r.ToInt32();

        public static explicit operator Single(Ratational r) => r.ToSingle();
    }
}
