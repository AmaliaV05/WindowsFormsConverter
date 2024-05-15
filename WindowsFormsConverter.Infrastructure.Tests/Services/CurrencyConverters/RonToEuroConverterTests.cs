﻿using FluentAssertions;
using System;
using System.Collections.Generic;
using WindowsFormsConverter.Core.Enum;
using WindowsFormsConverter.Infrastructure.Services.CurrencyConverters;
using Xunit;

namespace WindowsFormsConverter.Infrastructure.Tests.Services.CurrencyConverters
{
    public class RonToEuroConverterTests
    {
        [Theory]
        [InlineData("100", true, 21.1021)]
        [InlineData("100", false, 20.0973)]
        public void Converter_ValidAmount_ReturnsConvertedAmount(
            string value, 
            bool isTransactionFeeApplied, 
            decimal expectedAmount)
        {
            var item = new RonToEuroConverter();

            var actualAmount = item.Converter(value, isTransactionFeeApplied);

            actualAmount.Should().Be(expectedAmount);

            item.CurrencyFrom.Should().Be(Currency.RON);
            item.CurrencyTo.Should().Be(Currency.EUR);
        }

        [Theory]
        [MemberData(nameof(ConverterTestData))]
        public void Converter_AmountIsEqualToOrLessThanZeroOrHasExtremelyHighValue_ThrowsArgumentOutOfRangeException(string value, bool isTransactionFeeApplied, string errorMessage)
        {
            var item = new RonToEuroConverter();

            Action action = () => item.Converter(value, isTransactionFeeApplied);

            action
                .Should().Throw<ArgumentOutOfRangeException>()
                .WithMessage(errorMessage);
        }

        public static IEnumerable<object[]> ConverterTestData =>
            new List<object[]>
            {
                new object[] { "0", true, "Please enter a valid amount greater than zero\nParameter name: amount" },
                new object[] { "0", false, "Please enter a valid amount greater than zero\nParameter name: amount" },
                new object[] { "-100", true, "Please enter a valid amount greater than zero\nParameter name: amount" },
                new object[] { "-100", false, "Please enter a valid amount greater than zero\nParameter name: amount" },
                new object[] { Math.Pow(100, 29), true, "Please enter a valid amount\nParameter name: amount" },
                new object[] { Math.Pow(100, 29), false, "Please enter a valid amount\nParameter name: amount" }
            };
    }
}
