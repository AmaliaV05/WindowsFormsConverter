using System;
using WindowsFormsConverter.Application.Interfaces;
using WindowsFormsConverter.Core.Constants;
using WindowsFormsConverter.Core.Enum;

namespace WindowsFormsConverter.Infrastructure.Services
{
    public class CurrencyConverter : ICurrencyConverter
    {
        public virtual Currency CurrencyFrom { get; set; }
        public virtual Currency CurrencyTo { get; set; }

        public virtual decimal Converter(string value, bool applyTransactionFee)
        {
            if (!decimal.TryParse(value, out var amount))
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Please enter a valid amount");
            }

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Please enter a valid amount greater than zero");
            }

            decimal amountConverted;

            var currencyToCurrencyFrom = new Tuple<Currency, Currency>(CurrencyFrom, CurrencyTo);

            if (ConversionRates.Rates.TryGetValue(currencyToCurrencyFrom, out decimal conversionRate))
            {
                amountConverted = amount * conversionRate;
            }
            else
            {
                var currencyToCurrencyFromSwitched = new Tuple<Currency, Currency>(CurrencyTo, CurrencyFrom);
                conversionRate = ConversionRates.Rates[currencyToCurrencyFromSwitched];
                amountConverted = amount * (1 / conversionRate);
            }

            if (applyTransactionFee)
            {
                amountConverted *= TransactionFee.Value;
            }

            return Math.Round(amountConverted, 4);
        }
    }
}
