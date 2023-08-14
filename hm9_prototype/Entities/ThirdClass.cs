using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm9_prototype.Entities
{
    public class ThirdClass : SecondClass, ICloneable, IMyClonable<ThirdClass>
    {
        public string ThirdName { get; set; }

        public ThirdClass()
        {
            ThirdName = "Third class";
        }

        public ThirdClass(ThirdClass obj) : base(obj)
        {
            ThirdName = obj.ThirdName;
        }

        public new object Clone()
        {
            return new ThirdClass(this);
        }

        public new ThirdClass MyClone()
        {
            return new ThirdClass(this);
        }

        public override string ToString()
        {
            return base.ToString() + ", " + ThirdName;
        }
    }
}
