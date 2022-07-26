using NUnit.Framework;
using static FormattingStrings.Interpolation;

namespace FormattingStrings.Tests
{
    [TestFixture]
    public class InterpolationTests
    {
        [TestCase(842, "Lynette L. Emerson", "NL96ABNA5427658955", 403948.848275, 7451723.423581, 0.05, ExpectedResult = @"842,""Lynette L. Emerson"",7451723.42,""5.00 %"",""¤403,948.8483"",NL96ABNA5427658955")]
        [TestCase(34828, "Gabrielle Jansson", "ES9220384881688327463791", 98349502.58829, 1058373122342.471305, 0.15, ExpectedResult = @"34828,""Gabrielle Jansson"",1058373122342.47,""15.00 %"",""¤98,349,502.5883"",ES9220384881688327463791")]
        [TestCase(8948, "Kristin Fleischer", "DE32500105173655568294", 482836.43034, 482704134.38521, 0.1, ExpectedResult = @"8948,""Kristin Fleischer"",482704134.39,""10.00 %"",""¤482,836.4303"",DE32500105173655568294")]
        public string GetDepositCsv_ReturnsString(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            return GetDepositCsv(id, name, iban, deposit, balance, interestRate);
        }

        [TestCase(1, "Chai", 1, 1, "10 boxes x 20 bags", 18, 39, 0, 10, true, ExpectedResult = @"1,""Chai"",1,1,""10 boxes x 20 bags"",18.00,39,0,10,0")]
        [TestCase(10, "Ikura", 4, 8, "12 - 200 ml jars", 31, 31, 0, 0, true, ExpectedResult = @"10,""Ikura"",4,8,""12 - 200 ml jars"",31.00,31,0,0,0")]
        [TestCase(29, "Thüringer Rostbratwurst", 12, 6, "50 bags x 30 sausgs.", 123.79, 0, 0, 0, false, ExpectedResult = @"29,""Thüringer Rostbratwurst"",12,6,""50 bags x 30 sausgs."",123.79,0,0,0,1")]
        public string GetProductCsv_ReturnsString(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            return GetProductCsv(id, name, supplierId, categoryId, quantityPerUnit, unitPrice, unitInStock, unitsOnOrder, reorderLevel, discontinued);
        }

        [TestCase(842, "Lynette L. Emerson", "NL96ABNA5427658955", 403948.848275, 7451723.423581, 0.05, ExpectedResult = @"{ ""id"": 842, ""name"": ""Lynette L. Emerson"", ""balance"": 7451723.42, ""rate"": 0.05, ""deposit"": 403948.8483, ""account"": ""NL96ABNA5427658955"" }")]
        [TestCase(34828, "Gabrielle Jansson", "ES9220384881688327463791", 98349502.58829, 1058373122342.471305, 0.15, ExpectedResult = @"{ ""id"": 34828, ""name"": ""Gabrielle Jansson"", ""balance"": 1058373122342.47, ""rate"": 0.15, ""deposit"": 98349502.5883, ""account"": ""ES9220384881688327463791"" }")]
        [TestCase(8948, "Kristin Fleischer", "DE32500105173655568294", 482836.43034, 482704134.38521, 0.1, ExpectedResult = @"{ ""id"": 8948, ""name"": ""Kristin Fleischer"", ""balance"": 482704134.39, ""rate"": 0.10, ""deposit"": 482836.4303, ""account"": ""DE32500105173655568294"" }")]
        public string GetDepositJson_ReturnsString(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            return GetDepositJson(id, name, iban, deposit, balance, interestRate);
        }

        [TestCase(1, "Chai", 1, 1, "10 boxes x 20 bags", 18, 39, 0, 10, true, ExpectedResult = @"<product id=""1"" name=""Chai"" category=""1"" available=""Yes""><supplier>1</supplier><quantity>10 boxes x 20 bags</quantity><price>18.0000</price><stock>39</stock><ordered>0</ordered><reorder>10</reorder></product>")]
        [TestCase(10, "Ikura", 4, 8, "12 - 200 ml jars", 31, 31, 0, 0, true, ExpectedResult = @"<product id=""10"" name=""Ikura"" category=""8"" available=""Yes""><supplier>4</supplier><quantity>12 - 200 ml jars</quantity><price>31.0000</price><stock>31</stock><ordered>0</ordered><reorder>0</reorder></product>")]
        [TestCase(29, "Thüringer Rostbratwurst", 12, 6, "50 bags x 30 sausgs.", 123.79, 0, 0, 0, false, ExpectedResult = @"<product id=""29"" name=""Thüringer Rostbratwurst"" category=""6"" available=""No""><supplier>12</supplier><quantity>50 bags x 30 sausgs.</quantity><price>123.7900</price><stock>0</stock><ordered>0</ordered><reorder>0</reorder></product>")]
        public string GetProductXml_ReturnsString(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            return GetProductXml(id, name, supplierId, categoryId, quantityPerUnit, unitPrice, unitInStock, unitsOnOrder, reorderLevel, discontinued);
        }

        [TestCase(842, "Lynette L. Emerson", "NL96ABNA5427658955", 403948.848275, 7451723.423581, 0.05, ExpectedResult = @"|   842 | Lynette L. Emerson   | ¤7,451,723.4236          |  5 % | 403,948.85      | NL96ABNA5427658955        |")]
        [TestCase(34828, "Gabrielle Jansson", "ES9220384881688327463791", 98349502.58829, 1058373122342.471305, 0.15, ExpectedResult = @"| 34828 | Gabrielle Jansson    | ¤1,058,373,122,342.4700  | 15 % | 98,349,502.59   | ES9220384881688327463791  |")]
        [TestCase(8948, "Kristin Fleischer", "DE32500105173655568294", 482836.43034, 482704134.38521, 0.1, ExpectedResult = @"|  8948 | Kristin Fleischer    | ¤482,704,134.3852        | 10 % | 482,836.43      | DE32500105173655568294    |")]
        public string GetDepositTable_ReturnsString(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            return GetDepositTable(id, name, iban, deposit, balance, interestRate);
        }

        [TestCase(1, "Chai", 1, 1, "10 boxes x 20 bags", 18, 39, 0, 10, true, ExpectedResult = @"1    Chai                       1 ¤18.00    39 10 boxes x 20 bags  ")]
        [TestCase(10, "Ikura", 4, 8, "12 - 200 ml jars", 31, 31, 0, 0, true, ExpectedResult = @"10   Ikura                      8 ¤31.00    31 12 - 200 ml jars    ")]
        [TestCase(29, "Thüringer Rostbratwurst", 12, 6, "50 bags x 30 sausgs.", 123.79, 0, 0, 0, false, ExpectedResult = @"29   Thüringer Rostbratwurst    6 ¤123.79    0 50 bags x 30 sausgs.")]
        public string GetProductList_ReturnsString(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            return GetProductList(id, name, supplierId, categoryId, quantityPerUnit, unitPrice, unitInStock, unitsOnOrder, reorderLevel, discontinued);
        }
    }
}
