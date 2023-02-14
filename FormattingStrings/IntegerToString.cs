using System.Globalization;

[assembly: CLSCompliant(true)]

namespace FormattingStrings
{
    public static class IntegerToString
    {
        public static string LiteralToString1()
        {
            // Analyze the method unit tests and implement the method.
            return 1000.ToString(CultureInfo.InvariantCulture);
        }

        public static string LiteralToString2()
        {
            return 1234.ToString(CultureInfo.InvariantCulture);
        }

        public static string LiteralToString3()
        {
            return 100_000_000.ToString("G", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString4()
        {
            const decimal number = -123456789;
            string str = number.ToString("G", CultureInfo.InvariantCulture);
            return str;
        }

        public static string LiteralToString5()
        {
            return 0xABCDEFAB.ToString("X", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString6()
        {
            return 0xafbaceda.ToString("x", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString7()
        {
            return 0xA.ToString("x4", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString8()
        {
            return 0x00000FED.ToString("X8", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString9()
        {
            return 0xA.ToString("D4", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString10()
        {
            return 00004077.ToString("D8", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString11()
        {
            return 1394.ToString("C", CultureInfo.InvariantCulture);
        }

        public static string LiteralToString12()
        {
            return 2_8549.ToString("C6", CultureInfo.InvariantCulture);
        }
    }
}
