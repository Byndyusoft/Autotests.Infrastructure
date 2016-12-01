using System.Diagnostics;
using NUnit.Framework;

namespace ByndyuSoft.YandexSite.Tests.Tests.MainPage
{
    [TestFixture]
    public class MainPageTests
    {

        [Test]
        public void InputTextAndSearch()
        {
            var mainPage = Logic.MainPage
                .OpenPage()
                .SetTextInInputBox("12345")
                .SearchButtonCLick();

            Debugger.Break();
        }

    }
}
