using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAnalysis3Or4Step
{
    class Program 
    {
        static void Main(string[] args)
        {
            /* Türkçe: 3 basamaklı ise rakamları toplar.4 basamaklı ise 4 ile bölümününden kalanı ,
             5 basamaklı ise 5 ile böümünden kalanı kontrol eder. 
            English: This program Analysis number 3-4-5 digit . Adding the digits of a 3-digit number,
            calculating the remainder from dividing a 4-digit number by 4 , 
            calculating the remainder from dividing a 5-digit number by 5. 
            */ 
            Console.WriteLine("Please enter the number. Your number mustbe 3-4-5 digit. ");
            int number, DigitNumber;
            number = Convert.ToInt32(Console.ReadLine());
            DigitNumber = Convert.ToString(number).Length;
            Console.WriteLine("Number of digit:" + DigitNumber + " digit.");
            if (DigitNumber == 3)
            {
                int hundreds, tens, ones, squares;
                hundreds = number / 100;
                tens = (number - (hundreds * 100)) / 10;
                ones = ((number - (hundreds * 100)) - (tens * 10));
                squares = (hundreds * hundreds) + (tens * tens) + (ones * ones);
                Console.WriteLine(number + " " +squares);
                
            }
            else if (DigitNumber == 4)
            {
                int mod = number % 4;
                if (mod == 0)
                {
                    Console.WriteLine("This number dividing by 4  without a remainder.");
                    
                }
                else
                {
                    Console.WriteLine("This number isn't dividing by 4 without a remainder. ");
                    int remainderFour = number % 4; 
                    Console.WriteLine("Remainder:"+remainderFour);
                }
            }
            else if (DigitNumber==5)
            {
                int mod5 = number % 5;
                switch (mod5)
                {
                    case 0:
                        Console.WriteLine("This number dividing by 5 without remainder.");
                        break;
                    default:
                        Console.WriteLine("This number isn't dividing by 5 without remainder.");
                        int remainderFive = number % 5;
                        Console.WriteLine("Remainder:"+remainderFive);
                        break;
                } 
            }
            else
            {
                Console.WriteLine("You entered wrong number. Please try again later");
            }
            Console.WriteLine("Thanks for choosing us. ");
            /*
                Basit seviyede ingilizce kullanıldığından türkçe olarak güncellenebilir bir kod parçasıdır. 
             */

        }
    }
}