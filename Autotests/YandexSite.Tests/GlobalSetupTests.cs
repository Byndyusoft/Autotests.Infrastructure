using System;
using System.Configuration;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using Selenium.Infrastructure;

namespace YandexSite.Tests
{
    [SetUpFixture]
    public class GlobalSetupTests
    {
        private readonly Driver _driver = Driver.Instance;

        [OneTimeSetUp]
        // ReSharper disable once UnusedMember.Global
        public void GlobalSetup()
        {
            // DriversPath
            var driversPath = string.Empty;
            var directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            if (directoryName != null)
            {
                driversPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    ConfigurationManager.AppSettings["DriversPath"]);
            }

            // WebDriverWait
            var webDriverWaitTimeout = Convert.ToInt32(ConfigurationManager.AppSettings["WebDriverWaitTimeout"]);
            var webDriverWaitPollingInterval =
                Convert.ToInt32(ConfigurationManager.AppSettings["WebDriverWaitPollingInterval"]);
            // WebDriver timeouts
            var webDriverTimeoutsImplicitlyWait =
                Convert.ToInt32(ConfigurationManager.AppSettings["WebDriverTimeoutsImplicitlyWait"]);
            var webDriverTimeoutsPageLoadTimeout =
                Convert.ToInt32(ConfigurationManager.AppSettings["WebDriverTimeoutsPageLoadTimeout"]);
            // BaseUrl
            var baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            // SiteLogin
            var siteLogin = ConfigurationManager.AppSettings["SiteLogin"];
            // SitePassword
            var sitePassword = ConfigurationManager.AppSettings["SitePassword"];

            _driver.Manage()
                .SetDriversPath(driversPath)
                .SetupWebDriverWait(webDriverWaitTimeout, webDriverWaitPollingInterval)
                .SetWebDriverTimeoutsImplicitlyWait(webDriverTimeoutsImplicitlyWait)
                .SetWebDriverTimeoutsPageLoadTimeout(webDriverTimeoutsPageLoadTimeout)
                .SetBaseUrl(baseUrl)
                ;
        }

        [OneTimeTearDown]
        // ReSharper disable once UnusedMember.Global
        public void GlobalTeardown()
        {
            _driver.Dispose();
        }
    }
}