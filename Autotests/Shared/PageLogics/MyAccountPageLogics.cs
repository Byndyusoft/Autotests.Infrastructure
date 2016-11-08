using Shared.PageObjects.Pages;

namespace Shared.PageLogics
{
    internal class MyAccountPageLogics
    {
        public void OpenAllAboutGoogle()
        {
            var myAccountPage = new MyAccountPage();
            myAccountPage.Footer.ClickAllAboutGoogle();
        }
    }
}