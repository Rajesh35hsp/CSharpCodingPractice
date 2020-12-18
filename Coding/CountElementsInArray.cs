using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public static class CountElementsInArray
    {
        public static int ElementMoreThen50(int[] inputarr)
        {
            int[] countArr = new int[10];
            for (int i = 0; i < inputarr.Length; i++)
            {
                countArr[inputarr[i]]++;
                if (countArr[inputarr[i] ] > (inputarr.Length / 2))
                {
                    return inputarr[i];
                }
            }
            return 0;

        }
    }
}
