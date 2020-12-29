using System;
using OpenQA.Selenium;

namespace Games.Pages
{
    public class HeaderNav
    {
        public readonly HeaderNavMap map;

        public HeaderNav(IWebDriver driver)
        {
            map = new HeaderNavMap(driver);
        }

        public void GoToHomePage()
        {
            map.HomePageLink.Click();
        }

        public void GoToGamesPage()
        {
            map.GamesPageLink.Click();
        }

        public void GoToPrivacyPage()
        {
            map.PrivacyPageLink.Click();
        }
    }

    public class HeaderNavMap
    {
        IWebDriver _driver;

        public HeaderNavMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement HomePageLink => _driver.FindElement(By.CssSelector("a[class='navbar-brand']"));
        public IWebElement GamesPageLink => _driver.FindElement(By.CssSelector("a[href='/Games']"));
        public IWebElement PrivacyPageLink => _driver.FindElement(By.CssSelector("a[href='/Privacy']"));
    }
}
