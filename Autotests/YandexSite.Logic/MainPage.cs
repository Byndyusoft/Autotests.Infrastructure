using System.Threading;
using ByndyuSoft.YandexSite.PageObjects;
using Selenium.Infrastructure;

namespace ByndyuSoft.YandexSite.Logic
{
    public sealed class MainPage : YandexBase<MainPagePageObject>
    {
        private MainPage()
        {
            //Driver.Instance.GoToBaseUrl();
            //PageObject = MainPagePageObject.GetPage();
            //Thread.Sleep(1000); // ToDo: !!!
        }

        private MainPage(MainPagePageObject page)
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

        //protected sealed override MainPagePageObject PageObject { get; set; }

        protected override MainPagePageObject PageObject { get; set; }

        public void SetTextInInputBox(string text)
        {
            PageObject.SetTextInInputBox(text);
        }

        public void SearchButtonCLick()
        {
            PageObject.SearchButtonClick();
        }
    }
}
