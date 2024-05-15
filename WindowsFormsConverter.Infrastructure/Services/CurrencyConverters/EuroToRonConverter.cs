using WindowsFormsConverter.Core.Enum;

namespace WindowsFormsConverter.Infrastructure.Services.CurrencyConverters
{
    public class EuroToRonConverter : CurrencyConverter
    {
        public override Currency CurrencyFrom => Currency.EUR;
        public override Currency CurrencyTo => Currency.RON;

        public override decimal Converter(string value, bool applyTransactionFee)
        {
            return base.Converter(value, applyTransactionFee);
        }
    }
}
