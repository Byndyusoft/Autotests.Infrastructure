using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestInfrastructure.UI;

namespace Shared.PageObjects.Elements.Common
{
    //Часть страницы. Наследует часть страницы.
    public class HeaderElement : PagePartBase
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='b-user js-user']")] private readonly IWebElement _bell = null;

        public string GetMessagesCount()
        {
            return _bell.Text;
        }
    }
}