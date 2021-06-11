using System;

namespace Leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0 && year%400==0 || year%100!=0)
            {
                Console.WriteLine("Entered year " + year + " is a leap year");
            }
            else
            {
                Console.WriteLine("Entered year " + year + " is not a leap year");
            }
        }
    }
}
