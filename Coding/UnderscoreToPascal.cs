using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public static class UnderscoreToPascal
    {
        public static string ConvertToPascal(string underScoreString)
        {
            string[] words = underScoreString.Split('_');

            StringBuilder returnStr = new StringBuilder();

            foreach (string wrd in words)
            {
                returnStr.Append(wrd.Substring(0, 1).ToUpper());
                returnStr.Append(wrd.Substring(1).ToLower());

            }
            return returnStr.ToString();
        }
    }
}
