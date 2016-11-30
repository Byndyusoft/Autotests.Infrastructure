using System.Diagnostics;
using NUnit.Framework;
using YandexSite.Logic;

namespace YandexSite.Tests.Tests.MainPage
{
    [TestFixture]
    public class MainPageTests
    {

        [Test]
        public void InputTextAndSearch()
        {
            var mainPage = SiteManager.OpenMainPage();
            mainPage.SetTextInInputBox("12345");
            mainPage.SearchButtonCLick();

            Debugger.Break();
        }

    }
}
