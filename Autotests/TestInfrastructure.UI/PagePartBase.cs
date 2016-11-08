using OpenQA.Selenium.Support.PageObjects;

namespace TestInfrastructure.UI
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