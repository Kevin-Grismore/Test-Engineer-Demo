using System;
using Framework.Models;
using Framework.Selenium;
using OpenQA.Selenium;

namespace Games.Pages
{
    public class GameDetailsPage : PageBase
    {
        public readonly GameDetailsPageMap map;

        public GameDetailsPage()
        {
            map = new GameDetailsPageMap();
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
        public IWebElement GameTitle => Driver.FindElement(By.CssSelector("dd[id='title-desc']"));
        public IWebElement GameReleaseDate => Driver.FindElement(By.CssSelector("dd[id='releasedate-desc']"));
        public IWebElement GameGenre => Driver.FindElement(By.CssSelector("dd[id='genre-desc']"));
        public IWebElement GamePrice => Driver.FindElement(By.CssSelector("dd[id='price-desc']"));
        public IWebElement GameRating => Driver.FindElement(By.CssSelector("dd[id='rating-desc']"));

        public IWebElement AgeInput => Driver.FindElement(By.CssSelector("input[id='AgeString']"));
        public IWebElement CheckAgeButton => Driver.FindElement(By.CssSelector("input[value='Check']"));

        public IWebElement EditGameLink => Driver.FindElement(By.CssSelector("a[href*='Edit']"));
        public IWebElement BackToListLink => Driver.FindElement(By.CssSelector("a[id='back-to-list']"));
    }
}