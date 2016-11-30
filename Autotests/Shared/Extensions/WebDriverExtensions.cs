using OpenQA.Selenium.Support.UI;
using Selenium.Infrastructure;
using Shared.PageObjects;

namespace Shared.Extensions
{
    public static class WebDriverExtensions
    {
        public static void WaitPreloader(this Driver driver)
        {
            driver.Wait.Until(ExpectedConditions.InvisibilityOfElementLocated(new Preloader()));
        }
    }
}