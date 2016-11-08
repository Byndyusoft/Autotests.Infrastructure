using OpenQA.Selenium.Support.PageObjects;

namespace TestInfrastructure.UI
{
    public abstract class PageBase<TK> where TK : PageBase<TK>, new()
    {
        protected readonly Driver Driver;

        protected PageBase()
        {
            Driver = Driver.Instance;
            InitPage(this);
        }

        public string RelativeUrl { get; set; }

        public static void InitPage<T>(T pageClass) where T : PageBase<TK>
        {
            PageFactory.InitElements(pageClass, new DefaultElementLocator(Driver.Instance.WebDriver));
        }

        public static TK GetPage()
        {
            var page = new TK();
            InitPage(page);
            return page;
        }
    }
}