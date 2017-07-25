using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.Generic
{
    class ContravariantAndCovariant
    {
        public delegate TResult MyFunc<in T, out TResult>(T args);

        public void Test()
        {
            MyFunc<object, ArgumentException> mf1 = null;

            MyFunc<string, Exception> mf2 = mf1;
        }
    }

    public class GenericType<T> where T : class
    {
        private T _value;

        public GenericType(T value)
        {
            _value = value;
        }

        public TResult Converter<TResult>() where TResult : T // 无法设置 T : TResult
        {
            TResult res = (TResult)Convert.ChangeType(_value, typeof(TResult));

            return res;
        }
    }

    class AnotherGenericType<T, TResult> where TResult : class where T : TResult
    {
         private readonly T _value;

        public AnotherGenericType(T value)
        {
            _value = value;
        }

        public TResult Converter() 
        {
            TResult res = (TResult)Convert.ChangeType(_value, typeof(TResult));

            return res;
        }
    }
}
