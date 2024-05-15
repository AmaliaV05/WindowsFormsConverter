namespace WindowsFormsConverter.Application.Interfaces
{
    public interface ICurrencyConverter
    {
        decimal Converter(string value, bool applyTransactionFee);
    }
}
