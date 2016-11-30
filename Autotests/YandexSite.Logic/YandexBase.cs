using YandexSite.PageObjects;

namespace YandexSite.Logic
{
    public abstract class YandexBase<TPageObject> where TPageObject : YandexPage<TPageObject>, new()
    {
        protected abstract TPageObject PageObject { get; set; }
    }
}