using System;
using Framework.Selenium;
using OpenQA.Selenium;

namespace Games.Pages
{
    public class HeaderNav
    {
        public readonly HeaderNavMap map;

        public HeaderNav()
        {
            map = new HeaderNavMap();
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
        public IWebElement HomePageLink => Driver.FindElement(By.CssSelector("a[class='navbar-brand']"));
        public IWebElement GamesPageLink => Driver.FindElement(By.CssSelector("a[href='/Games']"));
        public IWebElement PrivacyPageLink => Driver.FindElement(By.CssSelector("a[href='/Privacy']"));
    }
}
