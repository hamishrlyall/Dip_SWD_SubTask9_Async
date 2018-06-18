using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dip_SWD_SubTask9_Async_ConsoleApp_MultiThreaded
{
      class Program
      {
            static void Main(string[] args)
            {
                  Console.WriteLine("Before we start thread");

                  Thread tid1 = new Thread(new ThreadStart(MyThread.Thread1));
                  Thread tid2 = new Thread(new ThreadStart(MyThread.Thread2));

                  Console.WriteLine(DateTime.Now);
                  tid1.Start();
                  Console.WriteLine(DateTime.Now);
                  tid2.Start();
                  Console.WriteLine(DateTime.Now);

                  Console.ReadKey();
            }
            public class MyThread
            {
                  public static void Thread1()
                  {
                        Console.WriteLine("Thread1 {0}", CalculateNthPrimeNumber(400000));
                  }
                  public static void Thread2()
                  {
                        Console.WriteLine("Thread2 {0}", CalculateNthPrimeNumber(250000));
                  }
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
