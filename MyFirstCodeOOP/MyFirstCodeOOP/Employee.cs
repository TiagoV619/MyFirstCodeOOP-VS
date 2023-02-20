using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public string HiringDate { get; set; }
        public int IsActive { get; set; }

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"---EMPLOYEE---\n\t" +
                $" ID: {Id}\n\t " +
                $" First Name: {FirstName} \n\t " +
                $" Last Name: {LastName} \n\t " +
                $"Birth date: {Birthday} \n\t " +
                $"Hiring Date: {HiringDate} \n\t " +
                $" Is active?: {IsActive}";
            /*return String.Format($"---EMPLOYEE---\n\t" +
                $" ID: {0}\n\t " +
                $" First Name: {1} \n\t " +
                $" Last Name: {2} \n\t " +
                $"Birth date: {3} \n\t " +
                $"Hiring Date: {4} \n\t " +
                $" Is active?: {5}",
                Id,
                FirstName,
                LastName,
                Birthday,
                HiringDate,
                IsActive);*/
        } 
            
)
            




        }

        #endregion
        #endregion
    }
}
