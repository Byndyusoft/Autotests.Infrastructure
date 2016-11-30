using OpenQA.Selenium.Support.PageObjects;

namespace Selenium.Infrastructure
{
    public abstract class PagePartBase
    {
        protected PagePartBase()
        {
            InitPage();
        }

        private void InitPage()
        {
            PageFactory.InitElements(this, new DefaultElementLocator(Driver.Instance.WebDriver));
        }
    }
}