using MyFirstCodeOOP;
using System;
using System.Collections;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("OOP CONCEPTS");
                Console.WriteLine("************");

                Console.WriteLine("Please write you birth day: ");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please write you birth month: ");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please write you birth year: ");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(day), Convert.ToInt32(month)));
                Console.WriteLine("");
                Console.WriteLine("*****Testing latest implementation*****");
                Console.WriteLine("");
                Employee salaryEmployee = new SalaryEmployee()

                {
                    Id = Convert.ToInt32(Console.ReadLine()),
                    FirstName = Console.ReadLine(),
                    LastName = Console.ReadLine(),
                    Birthday = new Date(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)),
                    HiringDate = new Date(2022,3,4),
                    IsActive = Convert.ToBoolean(Console.ReadLine()),
                    Salary = Convert.ToDecimal(Console.ReadLine()),


                };

                Console.WriteLine(salaryEmployee);

            }
            catch (Exception oli)
            {
                Console.WriteLine(oli.Message);
            }
          
            Console.WriteLine("");
        }

    }
}


/*
int year = 0;
int month = 0;
int day = 0;

Console.WriteLine("write the year please");
year = int.Parse(Console.ReadLine());

Console.WriteLine("write the month please ");
month = int.Parse(Console.ReadLine());

Console.WriteLine("write the day please ");
day = int.Parse(Console.ReadLine());

var dataObject = new Date(year, month, day);
Console.WriteLine(dataObject); */