using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    public static class Prime
    {
        public static void PrintPrimeNos(int tillx)
        {
            List<int> primeNos = new List<int>() { 2 };
            for (int i = 2; i < tillx; i++)
            {
                bool isPrime = true;
                foreach (int prime in primeNos)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                //for (int j = 2; j < i; j++)
                //{
                //    if (i % j == 0)
                //    {
                //        isPrime = false;
                //        break;
                //    }
                //}
                if (isPrime)
                {
                    primeNos.Add(i);
                    Console.WriteLine(i);
                }

            }

        }

    }
}
