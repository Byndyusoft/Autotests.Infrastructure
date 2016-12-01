using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ByndyuSoft.YandexSite.PageObjects
{
    public class MainPagePageObject : YandexPage<MainPagePageObject>
    {

        [FindsBy(How = How.Name, Using = "text")]
        private IWebElement InputBox { get; set; }

        [FindsBy(How = How.ClassName, Using = "suggest2-form__button")]
        private IWebElement SearchButton { get; set; }

        public void SetTextInInputBox(string text)
        {
            InputBox.Clear();
            InputBox.SendKeys(text);
        }

        public void SearchButtonClick()
        {
            SearchButton.Click();
        }

    }

}
