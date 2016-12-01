using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ByndyuSoft.YandexSite.PageObjects
{
    public class SearchResultsLinksPageObject : YandexPage<SearchResultsLinksPageObject>
    {

        [FindsBy(How = How.Id, Using = "serp-adv__found")]
        private IWebElement ResultsFoundText { get; set; }

    }
}
