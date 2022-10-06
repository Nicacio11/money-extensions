using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoneyExtension;

namespace MoneyExtensions.Tests;

[TestClass]
public class MoneyExtensionsTests
{
    [TestMethod]
    [DynamicData(nameof(DecimalValues), DynamicDataSourceType.Property)]
    public void ShouldConvertDecimalToInt(decimal value)
    {
        // arrange
        var @decimal = Convert.ToDecimal(value
        .ToString("N2")
        .Replace(",", "")
        .Replace(".", ""));

        // act
        var result = value.ToCents();

        // asserts
        Assert.AreEqual(@decimal, result);

    }    

    public static IEnumerable<object[]> DecimalValues =>
            new[] {
                new object[] { 128.98M },
                new object[] { 138.98M },
                new object[] { 128.98M },
                new object[] { 125.98M },
                new object[] { 121.98M }
            };
}