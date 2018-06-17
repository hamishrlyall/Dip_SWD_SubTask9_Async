using System;

namespace Dip_SWD_SubTask9_Async_ClassLibrary
{
    public class Calculator
    {
        public long CalculateNthPrimeNumber()
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
