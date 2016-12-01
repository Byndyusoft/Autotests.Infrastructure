using System.Threading;
using ByndyuSoft.YandexSite.PageObjects;
using Selenium.Infrastructure;

namespace ByndyuSoft.YandexSite.Logic
{
    public sealed class MainPage : YandexBase<MainPagePageObject>
    {
        private MainPage()
        {
        }

        public MainPage(MainPagePageObject page)
        {
            PageObject = page;
        }

        public static MainPage OpenPage()
        {
            Driver.Instance.GoToBaseUrl();
            var page = MainPagePageObject.GetPage();
            Thread.Sleep(1000); // ToDo: !!!
            return new MainPage(page);
        }

        protected override MainPagePageObject PageObject { get; set; }

        public MainPage SetTextInInputBox(string text)
        {
            PageObject.SetTextInInputBox(text);
            return this;
        }

        public MainPage SearchButtonCLick()
        {
            PageObject.SearchButtonClick();
            return this;
        }
    }
}
