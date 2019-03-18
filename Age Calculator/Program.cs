using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today

            Console.WriteLine("Enter your birthday");
            Console.Write("Year: ");
            int yyyy = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int mm = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int dd = int.Parse(Console.ReadLine());

            var birthday = new DateTime(yyyy, mm, dd);
            var result = DateTime.Now;
            Console.WriteLine($"You are {AgeCalculator(birthday)} years old");
            Console.ReadLine();
        }

        public static int AgeCalculator(DateTime param)
        {
            var today = DateTime.Now;
            var birthday = param;
            if (today.Month < birthday.Month)
            {
                return today.Year - (birthday.Year + 1);
            }
            else if (today.Month == birthday.Month)
            {
                if (today.Day < birthday.Day)
                {
                    return today.Year - (birthday.Year + 1);
                }
                else
                {
                    return today.Year - birthday.Year;
                }

            }
            else
            {
                return today.Year - birthday.Year;
            }
        }
    }
}

       
