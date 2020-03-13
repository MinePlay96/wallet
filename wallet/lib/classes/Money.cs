using System;
using System.Collections.Generic;
using System.Text;

namespace wallet
{
    class Money
    {
        public double Amount { get; protected set; }
        public Currency Currency { get; protected set; }

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

        public Money Subtract (Money money)
        {
            if (this.Currency == money.Currency)
            {
                // just add amount
                this.Amount -= money.Amount;
                return new Money(this.Currency, money.Amount);
            } 
            
            // convert currency and add
            double convertedAmount = Money.Convert(this.Currency, money.Currency, money.Amount);
            this.Amount -= convertedAmount;
            return new Money(this.Currency, convertedAmount);

        }

        public static double Convert(Currency from, Currency to, double toConvertAmount)
        {
            return to.ConvertFromEuro(from.ConvertToEuro(toConvertAmount));
        }
    }
}
