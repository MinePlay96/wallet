using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class Currency
    {
        public string Name { get; protected set; }
        // x of this equils one euro
        protected double EuroConversionFactor { get; set; }

        public Currency(string name, double euroConversionFactor)
        {
            this.Name = name;
            this.EuroConversionFactor = euroConversionFactor;
        }

        public double ConvertToEuro(double amount)
        {
            return amount * this.EuroConversionFactor;
        }

        public double ConvertFromEuro(double amount)
        {
            return amount / this.EuroConversionFactor;
        }
    }
}
