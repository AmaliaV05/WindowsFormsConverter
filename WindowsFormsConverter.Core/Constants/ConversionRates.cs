using System;
using System.Collections.Generic;
using WindowsFormsConverter.Core.Enum;

namespace WindowsFormsConverter.Core.Constants
{
    public static class ConversionRates
    {
        public static Dictionary<Tuple<Currency, Currency>, decimal> Rates = new Dictionary<Tuple<Currency, Currency>, decimal>()
        {
            { new Tuple<Currency, Currency>(Currency.USD, Currency.EUR), 0.9283m },
            { new Tuple<Currency, Currency>(Currency.EUR, Currency.RON), 4.9758m },
            { new Tuple<Currency, Currency>(Currency.USD, Currency.RON), 4.6192m }
        };
    }
}
