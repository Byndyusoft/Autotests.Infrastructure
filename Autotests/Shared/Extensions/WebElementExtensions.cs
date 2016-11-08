using System.Linq;
using OpenQA.Selenium;

namespace Shared.Extensions
{
    public static class WebElementExtensions
    {
        public static bool CheckBoxIsSelected(this IWebElement element)
        {
            return element.HasClass("is-checked");
        }

        public static bool HasClass(this IWebElement element, string className)
        {
            return element.GetAttribute("class").Split(' ').Any(x => x.Equals(className));
        }
    }
}