using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyExtension;
public static class Money
{
    public static int ToCents(this decimal value)
    {
        if( value < 0)
            return 0;

        var valueInText = value
        .ToString("N2")
        .Replace(",", "")
        .Replace(".", "");

        if(string.IsNullOrEmpty(valueInText))
        {
            return 0;
        }

        int.TryParse(valueInText, out var result);
        return result;
    }
}