using System.Threading;
using Selenium.Infrastructure;
using YandexSite.PageObjects;

namespace YandexSite.Logic
{
    public class MainPage : YandexBase<MainPagePageObject>
    {
        public MainPage()
        {
            Driver.Instance.GoToBaseUrl();
            PageObject = MainPagePageObject.GetPage();
            Thread.Sleep(1000); // ToDo: !!!
        }

        public MainPage(MainPagePageObject page)
        {
            PageObject = page;
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
