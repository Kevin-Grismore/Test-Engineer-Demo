using Framework.Selenium;
using OpenQA.Selenium;

namespace Games.Pages
{
    public class GamesPage : PageBase
    {
        public readonly GamesPageMap map;

        public GamesPage()
        {
            map = new GamesPageMap();
        }

        public GamesPage GoTo()
        {
            headerNav.GoToGamesPage();
            return this;
        }

        public void GoToCreatePage()
        {
            map.CreateNewGameLink.Click();
        }

        public IWebElement GameEditByName(string name)
        {
            return map.GameEditLink(name);
        }

        public IWebElement GameDetailsByName(string name)
        {
            return map.GameDetailsLink(name);
        }

        public IWebElement GameDeleteByName(string name)
        {
            return map.GameDeleteLink(name);
        }
    }

    public class GamesPageMap
    {
        public IWebElement CreateNewGameLink => Driver.FindElement(By.CssSelector("a[href='/Games/Create']"));

        public IWebElement GenreDropdown => Driver.FindElement(By.CssSelector("select[id='GameGenre']"));
        public IWebElement SearchInput => Driver.FindElement(By.CssSelector("input[id='SearchString']"));
        public IWebElement FilterButton => Driver.FindElement(By.CssSelector("input[value='Filter']"));

        public IWebElement GameEditLink(string name) => Driver.FindElement(By.CssSelector($"a[id='Edit {name}']"));
        public IWebElement GameDetailsLink(string name) => Driver.FindElement(By.CssSelector($"a[id='Details {name}']"));
        public IWebElement GameDeleteLink(string name) => Driver.FindElement(By.CssSelector($"a[id='Delete {name}']"));
    }
}