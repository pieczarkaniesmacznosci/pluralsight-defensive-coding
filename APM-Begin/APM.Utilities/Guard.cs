using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace APM.SL
{
  public static class Guard
  {
    public static void ThrowIfNullOrEmpty(string argumentValue, string message, string parameterName)
    {
      if (string.IsNullOrWhiteSpace(argumentValue)) throw new ArgumentException(message, parameterName);
    }

    public static decimal ThrowIfNotPositiveDecimal(string argumentValue, string message, string parameterName)
        {
            var style = NumberStyles.Number;
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var success = decimal.TryParse(argumentValue,style, culture, out decimal result); ;
      if (!success || result < 0) throw new ArgumentException(message, parameterName);

      return result;
    }

    public static decimal ThrowIfNotPositiveNonZeroDecimal(string argumentValue, string message, string parameterName)
        {
            var style = NumberStyles.Number;
            var culture = CultureInfo.CreateSpecificCulture("en-US");
            var success = decimal.TryParse(argumentValue, style, culture, out decimal result);
      if (!success || result <= 0) throw new ArgumentException(message, parameterName);

      return result;
    }
  }
}
