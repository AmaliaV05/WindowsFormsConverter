using WindowsFormsConverter.Core.Enum;

namespace WindowsFormsConverter.Infrastructure.Services.CurrencyConverters
{
    public class RonToDollarConverter : CurrencyConverter
    {
        public override Currency CurrencyFrom => Currency.RON;
        public override Currency CurrencyTo => Currency.USD;

        public override decimal Converter(string value, bool applyTransactionFee)
        {
            return base.Converter(value, applyTransactionFee);
        }
    }
}
