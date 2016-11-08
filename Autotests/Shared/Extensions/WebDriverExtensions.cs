using OpenQA.Selenium.Support.UI;
using Shared.PageObjects;
using TestInfrastructure.UI;

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