using System.Diagnostics;
using ByndyuSoft.YandexSite.Logic;
using NUnit.Framework;

namespace ByndyuSoft.YandexSite.Tests.Tests.MainPage
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
