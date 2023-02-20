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




        }

        #endregion
        #endregion
    }
}
