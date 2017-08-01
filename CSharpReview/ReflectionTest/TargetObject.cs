using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.ReflectionTest
{
    internal class TargetObject
    {

        public TargetObject(int i, string str)
        {
            Id = i;
            Name = str;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("{0} with id {1} is Doing Something........", Name, Id);
        }

        public void DoOtherThing()
        {
            Console.WriteLine("{0} with id {1} is Doing other thing......", Name, Id);
        }
    }
}
