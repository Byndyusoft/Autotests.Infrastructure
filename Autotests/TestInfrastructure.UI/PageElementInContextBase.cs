using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestInfrastructure.UI
{
    public abstract class PageElementInContextBase
    {
        protected readonly IWebElement RootElement;

        protected PageElementInContextBase(IWebElement rootElement)
        {
            RootElement = rootElement;
            InitPage();
        }

        protected void InitPage()
        {
            PageFactory.InitElements(this, new DefaultElementLocator(RootElement));
        }

        protected static TPageElement GetPageElement<TPageElement>(TPageElement pageElement, IWebElement rootElement)
            where TPageElement : PageElementInContextBase
        {
            PageFactory.InitElements(pageElement, new DefaultElementLocator(rootElement));
            return pageElement;
        }
    }
}