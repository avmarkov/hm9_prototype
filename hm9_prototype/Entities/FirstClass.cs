using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm9_prototype.Entities
{
    public class FirstClass : ICloneable, IMyClonable<FirstClass>
    {
        public string FirstField { get; set; }
        public FirstClass()
        {
            FirstField = "First class";
        }

        public FirstClass(FirstClass obj)
        {
            FirstField = obj.FirstField;
        }
        public object Clone()
        {
            return new FirstClass(this);
        }

        public FirstClass MyClone()
        {
            return new FirstClass(this);
        }

        public override string ToString()
        {
            return FirstField;
        }
    }
}
