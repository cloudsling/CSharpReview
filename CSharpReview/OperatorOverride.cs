using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace CSharpReview
{
    class OperatorOverride
    {
        public int Id { get; set; }
        public int Tag { get; set; }
        public string Name { get; set; }

        public static OperatorOverride operator +(OperatorOverride thisObj, OperatorOverride other)
        {
            return new OperatorOverride
            {
                Id = thisObj.Id + other.Id,
                Tag = thisObj.Tag * other.Tag,
                Name = thisObj.Name
            };
        }
    }
}
