using Shared.PageObjects.Elements;
using Shared.PageObjects.Elements.Common;
using TestInfrastructure.UI;

namespace Shared.PageObjects.Pages.Common
{
    public abstract class PageWithoutSearch<TPage> : PageBase<TPage> where TPage : PageBase<TPage>, new()
    {
        public HeaderElement Header { get; } = new HeaderElement();
        public CustomFooterElement Footer { get; } = new CustomFooterElement();
    }
}