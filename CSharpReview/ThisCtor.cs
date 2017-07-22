using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview
{
    class ThisCtor
    {
        private int _count;

        private string _name;

        private double _accul;

        public ThisCtor()
        {
            _count = 1;
            _name = "This is a string";
            _accul = 4.2;
        }

        public ThisCtor(int count) : this()
        {
            _count = count;
        }

        // Other ctors
    }
}
