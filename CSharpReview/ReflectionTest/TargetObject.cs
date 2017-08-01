using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpReview.ReflectionTest
{
    internal class TargetObject
    {
        public TargetObject() { }

        public TargetObject(int i, string str)
        {
            Id = i;
            Name = str;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public void DoSomething()
        {
            Console.WriteLine("Doing Something");
        }

        public void DoOtherThing()
        {
            Console.WriteLine("Doing other thing......");
        }
    }
}
