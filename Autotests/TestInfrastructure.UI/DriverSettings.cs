namespace Selenium.Infrastructure
{
    internal static class DriverSettings
    {
        // Common Driver settings
        internal static string DriversPath { get; set; }
        internal static string BaseUrl { get; set; }

        // WebDriver settings
        internal static int WebDriverTimeoutsImplicitlyWait { get; set; } = 0;
        internal static int WebDriverTimeoutsPageLoadTimeout { get; set; } = -1;

        // WebDriver Wait settings
        internal static int WaitTimeOut { get; set; } = 30;
        internal static int WaitTimePollingInterval { get; set; } = 1;
    }
}