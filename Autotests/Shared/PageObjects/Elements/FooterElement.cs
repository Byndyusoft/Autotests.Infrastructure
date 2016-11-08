using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestInfrastructure.UI;

namespace Shared.PageObjects.Elements
{
    //Часть страницы. Наследует часть страницы.
    public class FooterElement : PagePartBase
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='b-user js-user']")] private readonly IWebElement _settinksLink
            = null;

        public string ClickSettingsLink()
        {
            return _settinksLink.Text;
        }

        public IWebElement GetSomeElem()
        {
            throw new NotImplementedException();
        }
    }
}