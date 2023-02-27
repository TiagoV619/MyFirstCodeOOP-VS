using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class Basecomissionemployee : ComissionEmployee
    {
        #region
        public decimal Base { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return ((Sales * (decimal)Convertpercentage(ComissionPercentage)) + Base);
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
            $" \n\tBase Salary..... {Base:C2}" +
            $" \n\tValue to pay............ {GetValueToPay():C2}";

        }

        #endregion
    }
}
