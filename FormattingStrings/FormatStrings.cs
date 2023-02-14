using System.Globalization;

namespace FormattingStrings
{
    public static class FormatStrings
    {
        public static string Format1(int number1, int number2, float number3, double number4)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{0} {2} {1} {3}", number1, number2, number3, number4);
        }

        public static string Format2(string str1, double number1, string str2, float number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{0} {1} {2} {3} {4}", str2, number2, number1, number3, str1);
        }

        public static string Format3(string str1, float number1, double number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{3}, {0}, {1:P0}, {2:C2}", str1, number1, number2, number3);
        }

        public static string Format4(int number1, int number2, long number3, string str1, string str2)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{1},{3},{0:X},{2},{4}", number1, number2, number3, str1, str2);
        }

        public static string Format5(string str1, double number1, int number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{{ \"id\": {3}, \"name\": \"{0}\", \"deposit\": {1:F2}, \"days\": {2:D3} }}", str1, number1, number2, number3);
        }

        public static string Format6(int number1, double number2, string str1, string str2, string str3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "{{ \"parameter\": \"{4}\", \"code\": {{ \"type\": \"{3}\", \"label\": \"{0:X4}\" }}, \"value\": {{ \"data\": \"{1:F2}\", \"units\": \"{2}\" }}}}", number1, number2, str1, str2, str3);
        }

        public static string Format7(string str1, string str2, float number1, float number2, int number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "|{4,6}|{0,9}|{2,8}|{1,9}|{3,6}|", str1, str2, number1, number2, number3);
        }

        public static string Format8(string str1, string str2, string str3, double number1, double number2, double number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "| {2,8} | {3,7} | {4,10} | {5,11} | {1,10} | {0,8} |", str1, str2, str3, number1, number2, number3);
        }

        public static string Format9(string str1, string str2, float number1, float number2, float number3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "| {4,10:P} | {0,-12} | {1,-14} | {3,12:C2} | {2,-20:N4} |", str1, str2, number1, number2, number3);
        }

        public static string Format10(decimal number1, decimal number2, double number3, string str1, string str2, string str3)
        {
            return string.Format(NumberFormatInfo.InvariantInfo, "| {3,-8} | {0,-12:F0} | {2,12:N2} | {5,15} | {4,11} | {1,-21:C4}|", number1, number2, number3, str1, str2, str3);
        }
    }
}
