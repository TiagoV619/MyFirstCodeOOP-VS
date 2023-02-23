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

                Console.WriteLine("Please write the year: ");
                var year = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please write the month: ");
                var month = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Please write the day: ");
                var day = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year), Convert.ToInt32(day), Convert.ToInt32(month)));


                Console.WriteLine("*****Testing latest implementation*****");
                Employee salaryEmployee = new SalaryEmployee()
                
                {
                    Id = 1000,
                    FirstName = "Santiago",
                    LastName = "Varela",
                    Birthday = new Date(30, 05, 2002),
                    HiringDate = new Date(2002, 12, 31),
                    IsActive = true,
                    Salary = 2000000.34M


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