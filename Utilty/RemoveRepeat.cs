using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class RemoveRepeat
    {
        public static List<string> DeleteRepeat(List<string> str)
        {

            return str.Distinct().ToList();

            //if (str.Count > 0)
            //{
            //    for (int i = 0; i < str.Count; i++)
            //    {
            //        for (int j = 0; j < str.Count; j++)
            //        {
            //            if (str[i] == str[j])
            //            {
            //                str.RemoveAt(j);
            //            }
            //        }
            //    }
            //}
            //return str;
        }
    }
}
