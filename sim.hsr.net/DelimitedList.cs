using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim.hsr.net
{
    internal class DelimitedList<T> : List<T>
    {
        public override string ToString()
        {
            return string.Join(",", this);
        }
    }
}
