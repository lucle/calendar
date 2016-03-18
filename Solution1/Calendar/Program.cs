using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthName = new string[] {"", "January", "February", "March", "April", "May", "June", "July", 
             "August", "September", "October", "November", "December"};

            Console.WriteLine("Enter month: ");
            string monthInput = Console.ReadLine();
            int month = int.Parse(monthInput);
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Month must be between 1 and 12");
                return;
            }

            Console.WriteLine("Enter year: ");
            string yearInput = Console.ReadLine();
            int year = int.Parse(yearInput);
            if (year < 0)
            {
                Console.WriteLine("Year must be positive");
                return;
            }

            int numberOfDays;
            switch (month)
            {
                case 2: // February
                    numberOfDays = 28;
                    if (year % 4 == 0)
                    {
                        numberOfDays = 29;
                        if (year % 100 == 0 && year % 400 != 0)
                            numberOfDays = 28;
                    }
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    numberOfDays = 30;
                    break;
                default: numberOfDays = 31;
                    break;
            }
            Console.WriteLine();
            for (int i = 1; i <= monthName.Length-1; i++)
            {
                if(month == i)
                Console.WriteLine(monthName[i]+" "+year);
            }
            
            for (int i = 1; i <= numberOfDays; i++)
            {
                if (i % 7 == 1)
                {
                    Console.WriteLine("");
                }
                Console.Write(i +" ");
            }
            Console.ReadLine();
        }
        
    }
}
