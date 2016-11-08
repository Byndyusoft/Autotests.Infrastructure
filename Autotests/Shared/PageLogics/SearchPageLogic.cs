using Shared.PageObjects.Pages;

namespace Shared.PageLogics
{
    public class SearchPageLogic
    {
        public void SearchPhrase(string phrase)
        {
            var searchPage = new SearchPage();
            searchPage.SearchModuleElement.FillSearchField(phrase);
            searchPage.SearchModuleElement.ClickSearchButton();
        }
    }
}