using System;
namespace PerfectNumberCalculators
{
  internal class Program
    {
        public static void Main(string[] args)
        { 
            /*
             Türkçe: Bu program mükemmel sayı bulmak için yazılmıştır.
             Mükemmel sayı, sayılar teorisinde, kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayı. 
             English: This program is written to find perfect number. 
             Perfeckt Number , In number theory, a perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself.
             */
            Console.WriteLine("Please enter the number.");
            int number = Convert.ToInt32((Console.ReadLine()));
            int total = 0;
            string divid = "";
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    total = total + i;
                    divid += i.ToString() + ' ';
                    

                }
            }
            Console.WriteLine(divid);
            if (total==number)
            {
                Console.WriteLine(number + "this number is Perfect Number");
                Console.WriteLine(divid + " = " + number);
                
            }
            else
            {
                Console.WriteLine(number+ "This isn't Perfect Number");
                
            }
            
            
        }
        
    }
}