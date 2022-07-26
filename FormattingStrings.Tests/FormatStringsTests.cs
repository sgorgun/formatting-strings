using NUnit.Framework;
using static FormattingStrings.FormatStrings;

namespace FormattingStrings.Tests
{
    [TestFixture]
    public class FormatStringsTests
    {
        [TestCase(1, 1, 3f, 3.0, ExpectedResult = "1 3 1 3")]
        [TestCase(101, 101, 101.101f, 1000001.0001, ExpectedResult = "101 101.101 101 1000001.0001")]
        [TestCase(0xABCD, 0xEFAF, 345E-2f, 94823452E-10, ExpectedResult = "43981 3.45 61359 0.0094823452")]
        public string Format1_ReturnsString(int number1, int number2, float number3, double number4)
        {
            return Format1(number1, number2, number3, number4);
        }

        [TestCase("Alice", 4809.293, "Nelson", 707.003f, 0x1, ExpectedResult = "Nelson 707.003 4809.293 1 Alice")]
        [TestCase("Sophia", -5384.0023, "Baker", 950624.4923f, 0x2, ExpectedResult = "Baker 950624.5 -5384.0023 2 Sophia")]
        [TestCase("Joe", 11.840057, "Rivera", 10493843.30f, 0x3, ExpectedResult = "Rivera 10493843 11.840057 3 Joe")]
        public string Format2_ReturnsString(string str1, double number1, string str2, float number2, int number3)
        {
            return Format2(str1, number1, str2, number2, number3);
        }

        [TestCase("Roy Thompson", 0.301f, 309583.49938, 1, ExpectedResult = "1, Roy Thompson, 30 %, ¤309,583.50")]
        [TestCase("Julia Scott", 0.7391f, 94804038123.05934, 2, ExpectedResult = "2, Julia Scott, 74 %, ¤94,804,038,123.06")]
        [TestCase("Abigail Hill", 0.4f, 70384.803, 3, ExpectedResult = "3, Abigail Hill, 40 %, ¤70,384.80")]
        public string Format3_ReturnsString(string str1, float number1, double number2, int number3)
        {
            return Format3(str1, number1, number2, number3);
        }

        [TestCase(0xABCD, 1001, 595823492894, "James Wood", "England", ExpectedResult = "1001,James Wood,ABCD,595823492894,England")]
        [TestCase(0xF1D8, 1002, 493843, "Marie Foster", "Scotland", ExpectedResult = "1002,Marie Foster,F1D8,493843,Scotland")]
        [TestCase(0x4950, 1003, 4934840058483, "Danielle Kelly", "Ireland", ExpectedResult = "1003,Danielle Kelly,4950,4934840058483,Ireland")]
        public string Format4_ReturnsString(int number1, int number2, long number3, string str1, string str2)
        {
            return Format4(number1, number2, number3, str1, str2);
        }

        [TestCase("Jesse Brown", 3948204923.0, 120, 964, ExpectedResult = "{ \"id\": 964, \"name\": \"Jesse Brown\", \"deposit\": 3948204923.00, \"days\": 120 }")]
        [TestCase("Theresa Bailey", 2039485.94, 60, 4059, ExpectedResult = "{ \"id\": 4059, \"name\": \"Theresa Bailey\", \"deposit\": 2039485.94, \"days\": 060 }")]
        [TestCase("James Cooper", 4958204.84, 360, 241, ExpectedResult = "{ \"id\": 241, \"name\": \"James Cooper\", \"deposit\": 4958204.84, \"days\": 360 }")]
        public string Format5_ReturnsString(string str1, double number1, int number2, int number3)
        {
            return Format5(str1, number1, number2, number3);
        }

        [TestCase(0x0F41, 94835.9381, "bar", "LPZ", "pressure", ExpectedResult = "{ \"parameter\": \"pressure\", \"code\": { \"type\": \"LPZ\", \"label\": \"0F41\" }, \"value\": { \"data\": \"94835.94\", \"units\": \"bar\" }}")]
        [TestCase(0x9420, 11012.0, "volt", "KDQ", "voltage", ExpectedResult = "{ \"parameter\": \"voltage\", \"code\": { \"type\": \"KDQ\", \"label\": \"9420\" }, \"value\": { \"data\": \"11012.00\", \"units\": \"volt\" }}")]
        [TestCase(0x4A1C, 545029335.2341, "joule", "AKM", "energy", ExpectedResult = "{ \"parameter\": \"energy\", \"code\": { \"type\": \"AKM\", \"label\": \"4A1C\" }, \"value\": { \"data\": \"545029335.23\", \"units\": \"joule\" }}")]
        public string Format6_ReturnsString(int number1, double number2, string str1, string str2, string str3)
        {
            return Format6(number1, number2, str1, str2, str3);
        }

        [TestCase("Joe", "Doe", 59523.42f, 0.23f, 85345, ExpectedResult = "| 85345|      Joe|59523.42|      Doe|  0.23|")]
        [TestCase("Alexander", "Smith", 423.32f, 0.2f, 452, ExpectedResult = "|   452|Alexander|  423.32|    Smith|   0.2|")]
        [TestCase("Christian", "Rodriguez", 95839981f, 0.2354f, 540239, ExpectedResult = "|540239|Christian|95839980|Rodriguez|0.2354|")]
        public string Format7_ReturnsString(string str1, string str2, float number1, float number2, int number3)
        {
            return Format7(str1, str2, number1, number2, number3);
        }

        [TestCase("Dylan", "Harris", "Welsh", 9545.34, 50064.3439, 94.002, ExpectedResult = "|    Welsh | 9545.34 | 50064.3439 |      94.002 |     Harris |    Dylan |")]
        [TestCase("Lawrence", "Campbell", "Scottish", 34.36, 3954.394, 9493284.099, ExpectedResult = "| Scottish |   34.36 |   3954.394 | 9493284.099 |   Campbell | Lawrence |")]
        [TestCase("Vincent", "Richardson", "English", 395.309, 593.39, 2934.3898, ExpectedResult = "|  English | 395.309 |     593.39 |   2934.3898 | Richardson |  Vincent |")]
        public string Format8_ReturnsString(string str1, string str2, string str3, double number1, double number2, double number3)
        {
            return Format8(str1, str2, str3, number1, number2, number3);
        }

        [TestCase("Zachary", "Jimenez", 1830000000f, 1030.3774f, 0.4781f, ExpectedResult = "|    47.81 % | Zachary      | Jimenez        |    ¤1,030.38 | 1,830,000,000.0000   |")]
        [TestCase("Benjamin", "Ross", 98454200f, 59093.8395f, 0.0096f, ExpectedResult = "|     0.96 % | Benjamin     | Ross           |   ¤59,093.84 | 98,454,200.0000      |")]
        [TestCase("Anthony", "Gutierrez", 48300000000f, 907533.9372f, 0.3102f, ExpectedResult = "|    31.02 % | Anthony      | Gutierrez      |  ¤907,533.94 | 48,299,999,232.0000  |")]
        public string Format9_ReturnsString(string str1, string str2, float number1, float number2, float number3)
        {
            return Format9(str1, str2, number1, number2, number3);
        }

        [TestCase(34823094.342, 593023.3041, 705245.9304, "Spain", "Louis", "Ortiz", ExpectedResult = "| Spain    | 34823094     |   705,245.93 |           Ortiz |       Louis | ¤593,023.3041        |")]
        [TestCase(9583492394.59389, 593023.3041, 495823.0143, "Germany", "Martin", "Miller", ExpectedResult = "| Germany  | 9583492395   |   495,823.01 |          Miller |      Martin | ¤593,023.3041        |")]
        [TestCase(840391, 4310324833.859384, 3582306.483805, "Norway", "Lee", "Anderson", ExpectedResult = "| Norway   | 840391       | 3,582,306.48 |        Anderson |         Lee | ¤4,310,324,833.8594  |")]
        public string Format10_ReturnsString(decimal number1, decimal number2, double number3, string str1, string str2, string str3)
        {
            return Format10(number1, number2, number3, str1, str2, str3);
        }
    }
}
