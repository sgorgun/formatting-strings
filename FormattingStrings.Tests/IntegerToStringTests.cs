using NUnit.Framework;
using static FormattingStrings.IntegerToString;

namespace FormattingStrings.Tests
{
    [TestFixture]
    public class IntegerToStringTests
    {
        [Test]
        public void LiteralToString1_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString1();

            // Assert
            Assert.That(actualResult, Is.EqualTo("1000"));
        }

        [Test]
        public void LiteralToString2_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString2();

            // Assert
            Assert.That(actualResult, Is.EqualTo("1234"));
        }

        [Test]
        public void LiteralToString3_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString3();

            // Assert
            Assert.That(actualResult, Is.EqualTo("100000000"));
        }

        [Test]
        public void LiteralToString4_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString4();

            // Assert
            Assert.That(actualResult, Is.EqualTo("-123456789"));
        }

        [Test]
        public void LiteralToString5_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString5();

            // Assert
            Assert.That(actualResult, Is.EqualTo("ABCDEFAB"));
        }

        [Test]
        public void LiteralToString6_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString6();

            // Assert
            Assert.That(actualResult, Is.EqualTo("afbaceda"));
        }

        [Test]
        public void LiteralToString7_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString7();

            // Assert
            Assert.That(actualResult, Is.EqualTo("000a"));
        }

        [Test]
        public void LiteralToString8_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString8();

            // Assert
            Assert.That(actualResult, Is.EqualTo("00000FED"));
        }

        [Test]
        public void LiteralToString9_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString9();

            // Assert
            Assert.That(actualResult, Is.EqualTo("0010"));
        }

        [Test]
        public void LiteralToString10_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString10();

            // Assert
            Assert.That(actualResult, Is.EqualTo("00004077"));
        }

        [Test]
        public void LiteralToString11_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString11();

            // Assert
            Assert.That(actualResult, Is.EqualTo("¤1,394.00"));
        }

        [Test]
        public void LiteralToString12_ReturnsString()
        {
            // Act
            string actualResult = LiteralToString12();

            // Assert
            Assert.That(actualResult, Is.EqualTo("¤28,549.000000"));
        }
    }
}
