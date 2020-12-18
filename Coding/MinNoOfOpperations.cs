using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public class MinNoOfOpperations
    {
        public MinNoOfOpperations(int x, int y, string inputString)
        {
            X = x;
            Y = y;
            InputString = inputString;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string InputString { get; set; }

        public int FindMinOper()
        {
            int count = 0;
            string originalString = InputString;

            while (true)
            {
                count++;
                Shiftstring(X);
                //opera1
                if (string.Compare(InputString, originalString) == 0)
                {
                    break;
                }

                count++;

                //opera2

                Shiftstring( Y);
                if (string.Compare(InputString, originalString) == 0)
                {
                    break;
                }

            }

            return count;
        }

        private void Shiftstring(int shifts)
        {
            string str1 = InputString.Substring(0, InputString.Length  - shifts);

            string str2 = InputString.Substring(InputString.Length  - shifts, shifts);

            InputString = str2 + str1;
        }
    }
}
