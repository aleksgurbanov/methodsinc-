using System;

namespace task3new
{
    class Program
    {
        static void Main(string[] args)
        {
            double exam1 = 0, exam2 = 0;
            double average = (exam1 + exam2) / 2;
            
            Console.Write("birinci imtahani daxil edin:");
        firststep:


            exam1 = Convert.ToDouble(Console.ReadLine());
         secondstep:
                Console.Write("ikinci imtahan neticesini daxil edin:");
        
            exam2 = Convert.ToDouble(Console.ReadLine());
            calcavg(average);
        }
        static void calcavg (double average )
        { if(average >= 60)
            {
                Console.WriteLine("mezun oldunuz");

            }
            else
            {
                Console.WriteLine("kesildiniz");
            }



        }
    }
}
