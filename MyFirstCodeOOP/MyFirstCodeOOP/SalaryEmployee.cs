﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class SalaryEmployee : Employee
    {
        #region properties

        public decimal Salary { get; set; }




        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return Salary;
            
        }

        public override string ToString()
        {
            return $"{} \n\t Value to pay: {}";
            //39:24
        }

        #endregion


    }
}
