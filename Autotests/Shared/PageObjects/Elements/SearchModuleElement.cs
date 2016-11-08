using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TestInfrastructure.UI;

namespace Shared.PageObjects.Elements
{
    public class SearchModuleElement : PagePartBase
    {
        [FindsBy(How = How.ClassName, Using = "b-variant-form__footer")]
        private IWebElement SearchPhraseField { get; set; }

        [FindsBy(How = How.ClassName, Using = "b-variant-form__footer")]
        private IWebElement SearchButton { get; set; }

        public void MainSearchFieldInputText(string phrase)
        {
            SearchPhraseField.SendKeys(phrase);
        }

        public SearchModuleElement FillSearchField(string phrase)
        {
            throw new NotImplementedException();
            return this;
        }

        public SearchModuleElement ClickSearchButton()
        {
            throw new NotImplementedException();
            return this;
        }
    }
}