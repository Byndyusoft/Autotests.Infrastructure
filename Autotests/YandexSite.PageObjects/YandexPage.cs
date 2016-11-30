using Selenium.Infrastructure;

namespace YandexSite.PageObjects
{
    public abstract class YandexPage<TPage> : PageBase<TPage> where TPage : PageBase<TPage>, new()
    {

    }
}
