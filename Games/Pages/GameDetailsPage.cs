using System;
using Framework.Models;
using OpenQA.Selenium;

namespace Games.Pages
{
    public class GameDetailsPage : PageBase
    {
        public readonly GameDetailsPageMap map;

        public GameDetailsPage(IWebDriver driver) : base(driver)
        {
            map = new GameDetailsPageMap(driver);
        }

        public Game GetBaseGame()
        {
            return new Game
            {
                Title = map.GameTitle.Text,
                ReleaseDate = DateTime.Parse(map.GameReleaseDate.Text),
                Genre = map.GameGenre.Text,
                Price = Convert.ToDecimal(map.GamePrice.Text.Substring(1)),
                Rating = map.GameRating.Text
            };
        }

        public void EnterAge(int age)
        {
            map.AgeInput.SendKeys(age.ToString());
        }

        public void CheckAge()
        {
            map.CheckAgeButton.Click();
        }

        public void GoToEditPage()
        {
            map.EditGameLink.Click();
        }

        public void GoBackToList()
        {
            map.BackToListLink.Click();
        }
    }

    public class GameDetailsPageMap
    {
        IWebDriver _driver;
        
        public GameDetailsPageMap(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement GameTitle => _driver.FindElement(By.CssSelector("dd[id='title-desc']"));
        public IWebElement GameReleaseDate => _driver.FindElement(By.CssSelector("dd[id='releasedate-desc']"));
        public IWebElement GameGenre => _driver.FindElement(By.CssSelector("dd[id='genre-desc']"));
        public IWebElement GamePrice => _driver.FindElement(By.CssSelector("dd[id='price-desc']"));
        public IWebElement GameRating => _driver.FindElement(By.CssSelector("dd[id='rating-desc']"));

        public IWebElement AgeInput => _driver.FindElement(By.CssSelector("input[id='AgeString']"));
        public IWebElement CheckAgeButton => _driver.FindElement(By.CssSelector("input[value='Check']"));

        public IWebElement EditGameLink => _driver.FindElement(By.CssSelector("a[href*='Edit']"));
        public IWebElement BackToListLink => _driver.FindElement(By.CssSelector("a[id='back-to-list']"));
    }
}