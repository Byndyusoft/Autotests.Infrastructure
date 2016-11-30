using System.Globalization;
using System.Linq;

namespace Selenium.Infrastructure.Extensions
{
    public static class DoubleExtensions
    {
        public static string ToRuString(this double value, int precision = 3)
        {
            var format = $"0.{new string(Enumerable.Repeat('0', precision).ToArray())}";
            return value.ToString(format, CultureInfo.GetCultureInfo("ru-RU"));
        }
    }
}