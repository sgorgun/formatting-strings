using NUnit.Framework;
using static FormattingStrings.NumbersToString;

namespace FormattingStrings.Tests
{
    [TestFixture]
    public class NumbersToStringTests
    {
        [TestCase(1.1f, ExpectedResult = "1.1000")]
        [TestCase(1010.01f, ExpectedResult = "1010.0100")]
        [TestCase(1234567.12345f, ExpectedResult = "1234567.1250")]
        public string NumberToString1_ReturnsString(float number)
        {
            // Act
            return NumberToString1(number);
        }

        [TestCase(1.1, ExpectedResult = "1.10")]
        [TestCase(1010.001, ExpectedResult = "1010.00")]
        [TestCase(1234567.12345, ExpectedResult = "1234567.12")]
        public string NumberToString2_ReturnsString(double number)
        {
            // Act
            return NumberToString2(number);
        }

        [TestCase(1.1, ExpectedResult = "1.1000")]
        [TestCase(1010.01, ExpectedResult = "1,010.0100")]
        [TestCase(1234567.12345, ExpectedResult = "1,234,567.1235")]
        public string NumberToString3_ReturnsString(double number)
        {
            // Act
            return NumberToString3(number);
        }

        [TestCase(1.1, ExpectedResult = "1.10000000")]
        [TestCase(1010.01, ExpectedResult = "1,010.01000000")]
        [TestCase(1234567.12345, ExpectedResult = "1,234,567.12345000")]
        public string NumberToString4_ReturnsString(decimal number)
        {
            // Act
            return NumberToString4(number);
        }

        [TestCase(1.1f, ExpectedResult = "¤1.1")]
        [TestCase(1010.01f, ExpectedResult = "¤1,010.0")]
        [TestCase(1234567.12345f, ExpectedResult = "¤1,234,567.1")]
        public string NumberToString5_ReturnsString(float number)
        {
            // Act
            return NumberToString5(number);
        }

        [TestCase(1.1, ExpectedResult = "¤1.100")]
        [TestCase(1010.01, ExpectedResult = "¤1,010.010")]
        [TestCase(1234567.12345, ExpectedResult = "¤1,234,567.123")]
        public string NumberToString6_ReturnsString(decimal number)
        {
            // Act
            return NumberToString6(number);
        }

        [TestCase(1.1, ExpectedResult = "110.00 %")]
        [TestCase(1010.01, ExpectedResult = "101,001.00 %")]
        [TestCase(1234567.12345, ExpectedResult = "123,456,712.35 %")]
        public string NumberToString7_ReturnsString(double number)
        {
            // Act
            return NumberToString7(number);
        }

        [TestCase(1.1f, ExpectedResult = "110.00000 %")]
        [TestCase(1010.01f, ExpectedResult = "101,001.00098 %")]
        [TestCase(1234567.12345f, ExpectedResult = "123,456,712.50000 %")]
        public string NumberToString8_ReturnsString(float number)
        {
            // Act
            return NumberToString8(number);
        }

        [TestCase(1.1f, ExpectedResult = "1.1")]
        [TestCase(1010.01f, ExpectedResult = "1010.01")]
        [TestCase(1234567.12345f, ExpectedResult = "1.23457E+06")]
        public string NumberToString9_ReturnsString(float number)
        {
            // Act
            return NumberToString9(number);
        }

        [TestCase(1.1, ExpectedResult = "1.1")]
        [TestCase(1010.01, ExpectedResult = "1.01E+03")]
        [TestCase(1234567.12345, ExpectedResult = "1.23E+06")]
        public string NumberToString10_ReturnsString(double number)
        {
            // Act
            return NumberToString10(number);
        }
    }
}
