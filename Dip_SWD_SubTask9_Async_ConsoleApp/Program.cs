using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dip_SWD_SubTask9_Async_ClassLibrary;

namespace Dip_SWD_SubTask9_Async_ConsoleApp
{
    class Program
    {
        static async void Main(string[] args)
        {
            CalculateNthPrimeNumber();
            
            Console.ReadKey();
        }

        private static long CalculateNthPrimeNumber()
        {
            int count = 0;
            long a = 2;
            while (count < 40000)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}
