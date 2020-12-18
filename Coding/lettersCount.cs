using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public static class lettersCount
    {
        public static string GetCounts(string str)
        {
            string rtn = "";

            char[] c = str.ToCharArray();
            Array.Sort(c);

            int count = 1;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] != c[i + 1])
                {
                    rtn = rtn + c[i];
                    rtn = rtn + count;
                    count = 1;
                }
                else
                {
                    count++;
                }
            }

            return rtn;
        }

        public static string getcountsByDic(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            char[] chrs = str.ToCharArray();

            foreach (char c in chrs)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c] = dic[c] + 1;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
           //dic= dic.OrderBy(x => x.Key) as Dictionary<char;
            string s="";
            foreach (var item in dic.OrderBy(x => x.Key))
            {
                 s = s + item.Key.ToString() + item.Value.ToString();// dic.Keys.ElementAt(0).ToString() + dic.Values.ElementAt(0).ToString();

            }
            return s;

        }
    }
}
