using System;
namespace MyFirstCodeOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // consola fecha de nacimiento
                Console.WriteLine("********************");
                Console.WriteLine("*   OPP CONCEPTS   *");
                Console.WriteLine("********************");

                Console.WriteLine("Please wirte your birth date year: ");
                var year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please wirte your birth date month: ");
                var month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Please wirte your birth date day: ");
                var day = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine(new Date(Convert.ToInt32(year),Convert.ToInt32(month),Convert.ToInt32(day)));
                Console.WriteLine("");
                Console.WriteLine("******Testing lastest complementation******");
                Console.WriteLine("");
               
                // consola para salario

                Console.WriteLine("*******************");
                Console.WriteLine("* SALARY EMPLOYEE *");
                Console.WriteLine("*******************");

                Console.WriteLine("Please write You ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please write you Name: ");
                string firstname = Console.ReadLine();

                Console.WriteLine("Please write you last name: ");
                string lastname = Console.ReadLine();

                Console.WriteLine("Are you active?: ");
                bool isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Employee salaryEmployee = new SalaryEmployee()

                {
                    Id = ID,
                    FirstName = firstname,
                    LastName = lastname,
                    Birthday = new Date(2003, 05, 30),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isactive,
                    Salary = Convert.ToDecimal(Console.ReadLine()),


                };

                Console.WriteLine(salaryEmployee);

                Console.WriteLine("");
                //Aqui comienza la nueva consola para la comision 

                Console.WriteLine("************************");
                Console.WriteLine("*  COMISSION EMPLOYEE  *");
                Console.WriteLine("************************");

                Console.WriteLine("Please write You ID: ");
                ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please write you Name: ");
                firstname = Console.ReadLine();

                Console.WriteLine("Please write you last name: ");
                lastname = Console.ReadLine();

                Console.WriteLine("Are you active?: ");
                isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your Comission percentage: ");
                float comissionpercentege = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your sales: ");
                decimal sales = Convert.ToDecimal(Console.ReadLine());

                Employee comissionemployee = new ComissionEmployee()
                {
                    Id = ID,
                    FirstName = firstname,
                    LastName = lastname,
                    Birthday = new Date(2003, 05, 30),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isactive,
                    ComissionPercentage = comissionpercentege,
                    Sales = sales,
                    

                };

                Console.WriteLine(comissionemployee);

                // consola contrato empleado


                Console.WriteLine("*************************");
                Console.WriteLine("*  CONTRACTOR EMPLOYEE  *");
                Console.WriteLine("*************************");

                Console.WriteLine("Please write You ID: ");
                ID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please write you Name: ");
                firstname = Console.ReadLine();

                Console.WriteLine("Please write you last name: ");
                lastname = Console.ReadLine();

                Console.WriteLine("Are you active?: ");
                isactive = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter your number of hours: ");
                float hours = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Enter your value per hours: ");
                decimal hourvalue = Convert.ToDecimal(Console.ReadLine());

                Employee contractemployee = new ContractorEmployee()
                {
                    Id = ID,
                    FirstName = firstname,
                    LastName = lastname,
                    Birthday = new Date(2003, 05, 30),
                    HiringDate = new Date(2022, 3, 4),
                    IsActive = isactive,
                    hours = hours,
                    hourvalue = hourvalue,


                };

                Console.WriteLine(contractemployee);



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