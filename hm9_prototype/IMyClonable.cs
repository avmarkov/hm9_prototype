using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm9_prototype
{
    internal interface IMyClonable<T>
    {
        public T MyClone();
    }
}
