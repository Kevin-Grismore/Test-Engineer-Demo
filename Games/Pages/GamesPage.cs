using OpenQA.Selenium;

namespace Games.Pages
{
    public class GamesPage
    {
        public readonly GamesPageMap map;

        public GamesPage(IWebDriver driver)
        {
            map = new GamesPageMap(driver);
        }

        public void GoToCreatePage()
        {
            map.CreateNewGameLink.Click();
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

        public IWebElement GameEditLink(int id) => _driver.FindElement(By.CssSelector($"a[href*='Edit/{id}']"));
        public IWebElement GameDetailsLink(int id) => _driver.FindElement(By.CssSelector($"a[href*='Details/{id}']"));
        public IWebElement GameDeleteLink(int id) => _driver.FindElement(By.CssSelector($"a[href*='Delete/{id}']"));
    }
}