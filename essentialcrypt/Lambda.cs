using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace essentialcrypt
{
    public class Lambda
    {
        static Func<string, int, string>
        x = (f, n) => new string(f.Select<char, char>(c => (char)(c ^ n)).ToArray());

        public static string Encode(string input , int salt)
        {
            return x(input , salt);
        }
    }
}
