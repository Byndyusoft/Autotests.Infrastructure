using ByndyuSoft.YandexSite.PageObjects;

namespace ByndyuSoft.YandexSite.Logic
{
    public abstract class YandexBase<TPageObject> where TPageObject : YandexPage<TPageObject>, new()
    {
        protected abstract TPageObject PageObject { get; set; }
    }
}