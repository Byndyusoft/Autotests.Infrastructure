using Shared.PageObjects.Pages;

namespace Shared.PageLogics
{
    public class SmallPageLogic
    {
        public void SearchPhrase(string phrase)
        {
            var smallPage = new SmallPage();
            smallPage.SearchModuleElement.FillSearchField(phrase);
            smallPage.SearchModuleElement.ClickSearchButton();
        }
    }
}