using OpenQA.Selenium;

namespace Games.Pages
{
    public class GamesPage : PageBase
    {
        public readonly GamesPageMap map;

        public GamesPage(IWebDriver driver) : base(driver)
        {
            map = new GamesPageMap(driver);
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
        IWebDriver _driver;

        public GamesPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement CreateNewGameLink => _driver.FindElement(By.CssSelector("a[href='/Games/Create']"));

        public IWebElement GenreDropdown => _driver.FindElement(By.CssSelector("select[id='GameGenre']"));
        public IWebElement SearchInput => _driver.FindElement(By.CssSelector("input[id='SearchString']"));
        public IWebElement FilterButton => _driver.FindElement(By.CssSelector("input[value='Filter']"));

        public IWebElement GameEditLink(string name) => _driver.FindElement(By.CssSelector($"a[id='Edit {name}']"));
        public IWebElement GameDetailsLink(string name) => _driver.FindElement(By.CssSelector($"a[id='Details {name}']"));
        public IWebElement GameDeleteLink(string name) => _driver.FindElement(By.CssSelector($"a[id='Delete {name}']"));
    }
}