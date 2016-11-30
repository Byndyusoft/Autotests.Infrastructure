using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Selenium.Infrastructure;

namespace Shared.PageObjects.Elements
{
    public class CustomFooterElement : PagePartBase
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='b-user js-user']")] private readonly IWebElement _settinksLink
            = null;

        public string ClickSettingsLink()
        {
            return _settinksLink.Text;
        }

        public IWebElement ClickAllAboutGoogle()
        {
            throw new NotImplementedException();
        }
    }
}