using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpReview.ReflectionTest
{
    internal class ReflectionTest
    {
        public static void Test(object obj)
        {
            var obj1 = (TargetObject)CreateInstanceWithMethod(obj.GetType(), 12, "Schrodinger");
            var obj2 = (TargetObject)CreateInstanceByConstructor(obj.GetType(), 10, "Erwin");
            var obj3 = (TargetObject)obj;

            obj1.DoOtherThing();
            obj2.DoSomething();
            obj3.DoSomething();
        }

        public static object CreateInstanceByConstructor(Type ty, params object[] args)
        {
            ConstructorInfo[] ctorInfo = ty.GetConstructors();

            foreach (var info in ctorInfo)
            {
                if (info.GetParameters() != null)
                {
                    return info.Invoke(args);
                }
            }
            return new object();
        }

        public static object CreateInstanceWithMethod(Type ty, params object[] args)
        {
            return Activator.CreateInstance(ty, args);
        }
    }
}
