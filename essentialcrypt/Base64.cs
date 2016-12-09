using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace essentialcrypt
{
    public class Base64
    {
        public string Name { get { return "Base64"; } }

        public static string Decode(string input)
        {
            return WebUtility.UrlDecode(Encoding.UTF8.GetString(Convert.FromBase64String(input)));
        }

        public static string Encode(string input)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(WebUtility.UrlEncode(input)));
        }
    }
}
