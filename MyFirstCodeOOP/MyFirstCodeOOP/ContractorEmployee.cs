using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCodeOOP
{
    internal class ContractorEmployee : Employee
    {
        #region Properties

        public int hours { get; set; }
        public decimal hourvalue { get; set; }

        #endregion

        #region Methods
        public override decimal GetValueToPay()
        {
            return ((decimal)hours * hourvalue);
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
            $" \n\tNumber of hours..... {hours}" +
            $" \n\tValue of hours.......{hourvalue:C2}" +
            $" \n\tValue to pay... .... {GetValueToPay():C2}";

        }

        #endregion
    }

}
