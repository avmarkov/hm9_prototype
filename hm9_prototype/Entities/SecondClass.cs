using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm9_prototype.Entities
{
    public class SecondClass : FirstClass, ICloneable, IMyClonable<SecondClass>
    {
        public string SecondName { get; set; }

        public SecondClass(SecondClass obj) : base(obj)
        {
            SecondName = obj.SecondName;
        }

        public SecondClass()
        {
            SecondName = "Second class";
        }

        public new object Clone()
        {
            return new SecondClass(this);
        }

        public new SecondClass MyClone()
        {
            return new SecondClass(this);
        }

        public override string ToString()
        {
            return base.ToString() + ", " + SecondName;
        }

    }
}
