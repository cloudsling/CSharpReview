using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CSharpReview.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class FlyableAttribute : Attribute
    {
        private readonly Flyable _flyable;
        public FlyableAttribute(Flyable flyable)
        {
            _flyable = flyable;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (GetType() != obj.GetType()) return false;

            FlyableAttribute other = (FlyableAttribute)obj;

            return other._flyable == _flyable;
        }

        public override int GetHashCode()
        {
            return (int)_flyable;
        }
    }

    [Flags]
    public enum Flyable
    {
        CanFly = 0x0001,
        CannotFly = 0x0010
    }

    [Serializable]
    [Flyable(Flyable.CanFly)]
    public class AttributeSomeType { }

    public class AttributeOtherType { }

    internal class AttributeTest
    {
        internal static void Test()
        {
            var members = typeof(AttributeSomeType).GetTypeInfo().GetCustomAttributes();

            AttributeChecking1(members);

            Console.WriteLine(new FlyableAttribute(Flyable.CanFly).GetHashCode());
        }

        private static void AttributeChecking1(IEnumerable<Attribute> members)
        {
            foreach (var attr in members)
            {
                Console.WriteLine("{0}", attr.GetType().ToString());
            }
        }
    }
}
