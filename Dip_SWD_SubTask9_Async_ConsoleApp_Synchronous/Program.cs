﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip_SWD_SubTask9_Async_ConsoleApp_Synchronous
{
      class Program
      {
            static void Main(string[] args)
            {
                  Console.WriteLine(CalculateNthPrimeNumber(250000));
                  Console.WriteLine(CalculateNthPrimeNumber(400000));
            }

            public static long CalculateNthPrimeNumber(int n)
            {
                  int count = 0;
                  long a = 2;
                  while (count < n)
                  {
                        long b = 2;
                        int prime = 1;// to check if found a prime.
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
