using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
    internal class DelimitedDictionary<TKey,TValue> : Dictionary<TKey,TValue> where TKey: notnull
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach(var pair in this)
            {
                sb.Append('{');
                sb.Append(pair.Key);
                sb.Append(":");
                sb.Append(pair.Value);
                sb.Append("}");
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
