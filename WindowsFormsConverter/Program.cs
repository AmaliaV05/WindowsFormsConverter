using System;
using Unity;
using WindowsFormsConverter.Infrastructure.Services.CurrencyConverters;
using ApplicationInterface = WindowsFormsConverter.Application.Interfaces;
using Forms = System.Windows.Forms;

namespace WindowsFormsConverter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Forms.Application.EnableVisualStyles();
            Forms.Application.SetCompatibleTextRenderingDefault(false);

            UnityContainer container = new UnityContainer();
            container.RegisterType<ApplicationInterface.ICurrencyConverter, DollarToEuroConverter>();
            container.RegisterType<ApplicationInterface.ICurrencyConverter, DollarToRonConverter>();
            container.RegisterType<ApplicationInterface.ICurrencyConverter, EuroToDollarConverter>();
            container.RegisterType<ApplicationInterface.ICurrencyConverter, EuroToRonConverter>();
            container.RegisterType<ApplicationInterface.ICurrencyConverter, DollarToRonConverter>();
            container.RegisterType<ApplicationInterface.ICurrencyConverter, DollarToRonConverter>();

            Forms.Application.Run(container.Resolve<ConverterForm>());
        }
    }
}
