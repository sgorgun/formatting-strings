using System.Globalization;

namespace FormattingStrings
{
    public static class NumbersToString
    {
        public static string NumberToString1(float number)
        {
            return number.ToString("F4", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString2(double number)
        {
            return number.ToString("F2", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString3(double number)
        {
            return number.ToString("N4", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString4(decimal number)
        {
            return number.ToString("N8", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString5(float number)
        {
            return number.ToString("C1", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString6(decimal number)
        {
            return number.ToString("C3", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString7(double number)
        {
            return number.ToString("P2", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString8(float number)
        {
            return number.ToString("P5", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString9(float number)
        {
            return number.ToString("G6", NumberFormatInfo.InvariantInfo);
        }

        public static string NumberToString10(double number)
        {
            return number.ToString("G3", NumberFormatInfo.InvariantInfo);
        }
    }
}
