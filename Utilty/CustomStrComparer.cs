using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class CustomStrComparer : IEqualityComparer<string>
    {

        public bool Equals(string x, string y)
        {
            if (object.ReferenceEquals(x, y)) return true;

            if (string.IsNullOrEmpty(x) || string.IsNullOrEmpty(y))
                return false;

            return string.Equals(x.ToUpper(), y.ToUpper());
        }

        public int GetHashCode(string str)
        {
            //Check whether the object is null
            if (string.IsNullOrEmpty(str)) return 0;

            return str.GetHashCode();

        }
    }
}
