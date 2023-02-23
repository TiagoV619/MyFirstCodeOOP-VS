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
        public String LastName { get; set; }
        public Date Birthday { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        #endregion

        #region Methods

        public abstract decimal GetValueToPay();
        
        public override string ToString()
        {
           /* return $"---EMPLOYEE---\n\t" +
                $" ID: {Id}\n\t " +
                $" First Name: {FirstName} \n\t " +
                $" Last Name: {LastName} \n\t " +
                $"Birth date: {Birthday} \n\t " +
                $"Hiring Date: {HiringDate} \n\t " +
                $" Is active?: {IsActive}";*/
            return String.Format("---EMPLOYEE---\n\t" +
                " id ttettsdrenhshs: {0}\n\t " +
                " Last Name: {1} \n\t " +
                " First Name: {2} \n\t " +
                "Birth date: {3} \n\t " +
                "Hiring Date: {4} \n\t " +
                " Is active?: {5}",
                Id,
                FirstName,
                LastName,
                Birthday,
                HiringDate,
                IsActive);
        }
        #endregion
    }
}
   