using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Exercise16
    {
        public string swapFrontRear(string s)
        {
            char tmp;
            int l;

            char[] chars = s.ToArray();
            tmp = chars[0];
            l = s.Length;

            chars[0] = chars[l - 1];
            chars[l - 1] = tmp;

            return (new string(chars));
        }
    }
}
