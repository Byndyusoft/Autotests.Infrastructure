using OpenQA.Selenium;

namespace Shared.PageObjects
{
    internal class Preloader : By
    {
        public override IWebElement FindElement(ISearchContext context)
        {
            return
                context.FindElement(XPath("//div[@class='b-global-preloader js-global-preloader']"));
        }
    }
}