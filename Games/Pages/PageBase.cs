using OpenQA.Selenium;

namespace Games.Pages
{
    public abstract class PageBase
    {
        public readonly HeaderNav headerNav;

        public PageBase(IWebDriver driver)
        {
            headerNav = new HeaderNav(driver);
        }
    }
}