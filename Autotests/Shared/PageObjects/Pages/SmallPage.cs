using Shared.PageObjects.Elements;
using Shared.PageObjects.Pages.Common;

namespace Shared.PageObjects.Pages
{
    internal class SmallPage : SitePage<SmallPage>
    {
        public FooterElement Footer { get; } = new FooterElement();
    }
}