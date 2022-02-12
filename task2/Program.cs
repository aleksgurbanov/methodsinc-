using System;

namespace Task2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmazsa eded daxil edin");
            string reqem = Console.ReadLine();
            int num = int.Parse(reqem);
            Console.WriteLine(isprime(num));
        }

        static bool isprime(int a)
        {
            int netice = 0;
            int i = 0;
            
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    netice++;
                }






            }
            if (netice == 2)
                return true;
            return false;

        }


            



     }
 }
