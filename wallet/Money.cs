using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class Money
    {
        public double Amount { get; set; }
        protected Currency Currency { get; set; }

        public Money(Currency currency, double amount)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        public void Add(Money money)
        {
            if (this.Currency == money.Currency)
            {
                // just add amount
                this.Amount += money.Amount;
                return;
            }
            // convert currency and add
            this.Amount += Money.Convert(this.Currency, money.Currency, money.Amount);
        }

        public Money substract (double amonut)
        {
            this.Amount -= amonut;
            return new Money(this.Currency, amonut);
        }

        public static double Convert(Currency from, Currency to, double toConvertAmount)
        {
            return to.ConvertFromEuro(from.ConvertToEuro(toConvertAmount));
        }
    }
}
