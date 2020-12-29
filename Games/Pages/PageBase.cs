using OpenQA.Selenium;

namespace Games.Pages
{
    public abstract class PageBase
    {
        public readonly HeaderNav headerNav;

        public PageBase()
        {
            headerNav = new HeaderNav();
        }
    }
}