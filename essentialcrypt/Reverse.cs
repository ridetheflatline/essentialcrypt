using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essentialcrypt
{
    public class Reverse
    {
        public string Name { get { return "Reverse"; } }

        public static string Decode(string input)
        {
            return string.Concat(input.Reverse());
        }

        public static string Encode(string input)
        {
            return string.Concat(input.Reverse());
        }
    }
}
