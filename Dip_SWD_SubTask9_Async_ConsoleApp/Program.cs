﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip_SWD_SubTask9_Async_ConsoleApp
{
      class Program
      {
            public static void Main(string[] args)
            {
                  Console.WriteLine(DateTime.Now);
                  var task1 = FindPrimesAsync(250000);
                  Console.WriteLine(DateTime.Now);
                  var task2 = FindPrimesAsync(400000);
                  Console.WriteLine(DateTime.Now);

                  Console.WriteLine(task1.Result);
                  Console.WriteLine(task2.Result);

                  Console.ReadKey();

            }
            public static async Task<long> FindPrimesAsync(int n)
            {
                  var x = await Task.Run(() => CalculateNthPrimeNumber(n));
                  return x;
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