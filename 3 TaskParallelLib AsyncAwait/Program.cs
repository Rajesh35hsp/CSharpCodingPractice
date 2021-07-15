using System;
using System.Threading;
using System.Threading.Tasks;

namespace _3_TaskParallelLib_AsyncAwait
{
    class Program
    {
        static bool done = false;
        static void Main(string[] args)
        {
            try
            {
                var e = DoSomeTimeConsumingAsyn();
              //  while (!done)
                {
                    Console.WriteLine(System.DateTime.Now);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        static async Task DoSomeTimeConsumingAsyn()
        {
            try
            {
                await Task.Run(() => {
                    Thread.Sleep(5000);
                    Console.WriteLine("sm");
                    throw new Exception();
                });
            }
            catch (Exception)
            {
                done = true;

                throw;
            }

        }


    }
}
