using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    public class ComissionEmployee : Employee
    {
        #region Properties

        public float ComissionPercentage { get; set; }

        public decimal Sales { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {

            return (Sales * (decimal)Convertpercentage(ComissionPercentage)) + Sales;
        }


        public override string ToString()
        {
            return $"{base.ToString()}" +
            $" \n\tComissionPercentage..... {Convertpercentage(ComissionPercentage):P2}" +
            $" \n\tSales................... {Sales:C2}" +
            $" \n\tValue to pay............ {GetValueToPay():C2}";
        }

        public float Convertpercentage(float Comissionpercentage)
        {
            return (Comissionpercentage / 100);

        }

        #endregion
    }
}
