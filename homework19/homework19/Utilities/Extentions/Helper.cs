using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework19.Utilities.Extentions
{
    internal static class Helper
    {
        public static string Capitalized(this string word)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(word[0]));
            for (int i = 1; i < word.Length; i++)
            {
                sb.Append(char.ToLower(word[i]));
            }
            return sb.ToString();
        }
    }
}
