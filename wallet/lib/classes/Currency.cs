using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    public class Currency
    {
        public string Name { get; protected set; }
        // x of this equils one euro
        protected decimal EuroConversionFactor { get; set; }

        public Currency(string name, decimal euroConversionFactor)
        {
            this.Name = name;
            this.EuroConversionFactor = euroConversionFactor;
        }

        public decimal ConvertToEuro(decimal amount)
        {
            return amount * this.EuroConversionFactor;
        }

        public decimal ConvertFromEuro(decimal amount)
        {
            return amount / this.EuroConversionFactor;
        }
    }
}
