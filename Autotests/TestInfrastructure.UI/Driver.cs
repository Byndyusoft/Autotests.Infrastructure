using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Infrastructure
{
    public sealed class Driver : IDisposable
    {
        private static Driver _instance;
        private readonly List<IWebDriver> _drivers = new List<IWebDriver>();

        private readonly Options _options = new Options();
        private IWebDriver _webDriver;
        private WebDriverType _webDriverType;

        private Driver()
        {
            _webDriverType = WebDriverType.Chrome;
        }

        public WebDriverWait Wait { get; set; }

        public IWebDriver WebDriver => _webDriver ?? GetWebDriverByType(_webDriverType);

        public static Driver Instance
        {
            get
            {
                if (_instance != null) return _instance;
                _instance = new Driver();
                return _instance;
            }
        }

        public void Dispose()
        {
            foreach (var webDriver in _drivers)
                webDriver.Quit();
        }

        private IWebDriver GetWebDriverByType(WebDriverType webDriverType)
        {
            switch (webDriverType)
            {
                case WebDriverType.Chrome:
                    var chromeDriverService = ChromeDriverService.CreateDefaultService(DriverSettings.DriversPath);

                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--enable-keep-alive");
                    chromeOptions.AddArgument("--test-type"); // for --ignore-certificate-errors

                    _webDriver = new ChromeDriver(chromeDriverService, chromeOptions);

                    break;
                case WebDriverType.Firefox:
                    _webDriver = new FirefoxDriver();

                    break;
                case WebDriverType.InternetExplorer:
                    var internetExplorerDriverService =
                        InternetExplorerDriverService.CreateDefaultService(DriverSettings.DriversPath);

                    var internetExplorerOptions = new InternetExplorerOptions();
                    internetExplorerOptions.EnableNativeEvents = true;
                    //internetExplorerOptions.ForceCreateProcessApi = true;
                    //internetExplorerOptions.ForceShellWindowsApi = true;

                    _webDriver = new InternetExplorerDriver(internetExplorerDriverService, internetExplorerOptions);

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(webDriverType), webDriverType,
                        "Неизвестный тип WebDriver!");
            }

            _drivers.Add(_webDriver);
            _webDriverType = webDriverType;
            _webDriver.Manage()
                .Timeouts()
                .ImplicitlyWait(TimeSpan.FromSeconds(DriverSettings.WebDriverTimeoutsImplicitlyWait))
                .SetPageLoadTimeout(TimeSpan.FromSeconds(DriverSettings.WebDriverTimeoutsPageLoadTimeout));

            Wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DriverSettings.WaitTimeOut))
            {
                PollingInterval = TimeSpan.FromMilliseconds(DriverSettings.WaitTimePollingInterval)
            };

            return _webDriver;
        }

        public void SetWebDriverType(WebDriverType webDriverType)
        {
            if (_webDriverType == webDriverType) return;
            _webDriver = GetWebDriverByType(webDriverType);
        }

        public IWebElement FindElement(By target)
        {
            return WebDriver.FindElement(target);
        }

        public void WaitUntilDisplayedAndClick(By target)
        {
            WaitUntilDisplayed(target);
            Click(target);
        }

        public void WaitUntilDisplayed(By target)
        {
            var element = FindElement(target);
            Wait.Until(driver => element.Displayed);
        }

        public void Click(By target)
        {
            var element = FindElement(target);
            element.Click();
        }

        public void WaitUntilPageReady()
        {
            Wait.Until(
                driver => ((IJavaScriptExecutor) driver)
                    .ExecuteScript("return document.readyState")
                    .Equals("complete"));
        }

        public void SendKeys(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void GoToBaseUrl()
        {
            GoToUrl(DriverSettings.BaseUrl);
        }

        public void GoToRelativeUrl(string relativeUrl)
        {
            GoToUrl(DriverSettings.BaseUrl + relativeUrl);
        }

        public TPage GoToPage<TPage>(TPage page) where TPage : PageBase<TPage>, new()
        {
            GoToUrl(DriverSettings.BaseUrl + page.RelativeUrl);
            Thread.Sleep(5000);
            return page;
        }

        public void GoToUrl(string url)
        {
            WebDriver.Navigate()
                .GoToUrl(url);
            WaitUntilPageReady();
        }

        public Options Manage()
        {
            return _options;
        }

        public class Options
        {
            public Options SetWebDriverTimeoutsImplicitlyWait(int timeToWait)
            {
                DriverSettings.WebDriverTimeoutsImplicitlyWait = timeToWait;
                return this;
            }

            public Options SetWebDriverTimeoutsPageLoadTimeout(int timeToWait)
            {
                DriverSettings.WebDriverTimeoutsPageLoadTimeout = timeToWait;
                return this;
            }

            public Options SetupWebDriverWait(int timeout, int pollingInterval)
            {
                DriverSettings.WaitTimeOut = timeout;
                DriverSettings.WaitTimePollingInterval = pollingInterval;
                return this;
            }

            public Options SetBaseUrl(string baseUrl)
            {
                DriverSettings.BaseUrl = $"http://{baseUrl}";
                return this;
            }

            public Options SetBaseUrl(string baseUrl, string siteLogin, string sitePassword)
            {
                DriverSettings.BaseUrl = $"http://{siteLogin}:{sitePassword}@{baseUrl}";
                return this;
            }

            public Options SetDriversPath(string driversPath)
            {
                DriverSettings.DriversPath = driversPath;
                return this;
            }
        }
    }
}