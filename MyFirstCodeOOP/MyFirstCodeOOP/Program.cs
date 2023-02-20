using System;

namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
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
                Console.WriteLine(dataObject);
            }
            catch (Exception oli)
            {

                Console.WriteLine(oli.Message);
            }
            
            


            Console.WriteLine("");
        }
    }
}
