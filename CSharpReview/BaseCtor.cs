using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class BaseCtor
    {
        public BaseCtor(double accu)
        {
            _name = "Base Constructor";
            _accul = accu;
        }

        private string _name;

        private int _count;

        private double _accul;
    }

    class SubClass : BaseCtor
    {
        public SubClass(int count, double acc) : base(acc)
        {
            _otherCount = count;
        }

        private int _otherCount;
    }
}
