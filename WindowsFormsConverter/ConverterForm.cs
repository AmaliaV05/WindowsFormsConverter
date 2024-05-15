using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsConverter.Application.Interfaces;
using WindowsFormsConverter.Constants;
using WindowsFormsConverter.Core.Enum;
using WindowsFormsConverter.Infrastructure.Services.CurrencyConverters;
using WindowsFormsConverter.Common;

namespace WindowsFormsConverter
{
    public partial class ConverterForm : Form
    {
        private readonly List<Currency> _convertFromCurrencyList = new List<Currency>();
        private readonly List<Currency> _convertToCurrencyList = new List<Currency>();

        public ICurrencyConverter CurrencyConverter { get; set; }        

        public ConverterForm()
        {
            InitializeComponent();

            _convertFromCurrencyList.AddRange(CurrencyList.Values);
            lstConvertFromCurrency.DataSource = _convertFromCurrencyList;

            _convertToCurrencyList.AddRange(CurrencyList.Values);
            lstConvertToCurrency.DataSource = _convertToCurrencyList;
        }

        private void ConverterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var convertFromCurrency = (Currency)lstConvertFromCurrency.SelectedItems[0];
                var convertToCurrency = (Currency)lstConvertToCurrency.SelectedItems[0];

                if (convertFromCurrency == convertToCurrency)
                {
                    throw new ArgumentException("Please select different currencies");
                }

                var conversion = (convertFromCurrency, convertToCurrency);

                switch (conversion)
                {
                    case var tuple when tuple.convertFromCurrency == Currency.USD && tuple.convertToCurrency == Currency.EUR:
                        CurrencyConverter = new DollarToEuroConverter();
                        break;
                    case var tuple when tuple.convertFromCurrency == Currency.USD && tuple.convertToCurrency == Currency.RON:
                        CurrencyConverter = new DollarToRonConverter();
                        break;
                    case var tuple when tuple.convertFromCurrency == Currency.EUR && tuple.convertToCurrency == Currency.USD:
                        CurrencyConverter = new EuroToDollarConverter();
                        break;
                    case var tuple when tuple.convertFromCurrency == Currency.EUR && tuple.convertToCurrency == Currency.RON:
                        CurrencyConverter = new EuroToRonConverter();
                        break;
                    case var tuple when tuple.convertFromCurrency == Currency.RON && tuple.convertToCurrency == Currency.USD:
                        CurrencyConverter = new RonToDollarConverter();
                        break;
                    case var tuple when tuple.convertFromCurrency == Currency.RON && tuple.convertToCurrency == Currency.EUR:
                        CurrencyConverter = new RonToEuroConverter();
                        break;
                    default:
                        throw new Exception("Invalid selection");
                }

                var convertedAmount = CurrencyConverter.Converter(txtAmount.Text, chkApplyTransactionFee.Checked);
                txtConvertedAmount.Text = convertedAmount.ToString();
            }
            catch (Exception ex)
            {
                Alert.ShowValidationError(ex.Message);
            }            
        }
    }
}
