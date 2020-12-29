using System.IO;
using Games.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework.Services;
using Framework.Selenium;

namespace Games.UITests
{
    public class GameUITests
    {
        [SetUp]
        public void Setup()
        {
            Driver.Init();
            Driver.Current.Url = "https://localhost:5001/";
        }

        // 1. Go to Games page
        // 2. Assert Uncharted is displayed
        [Test]
        public void UnchartedIsOnGamesPage()
        {
            var gamesPage = new GamesPage(Driver.Current);
            gamesPage.GoTo();
            IWebElement uncharted = gamesPage.GameDetailsByName("Uncharted");
            Assert.That(uncharted.Displayed);
        }

        // 1. Go to Games page
        // 2. Click the Details link for a game
        // 3. Assert that the game's rating matches the expected rating

        static string[] gameNames = { "Uncharted", "Uncharted 2" };
        [Test, Category("Games")]
        [TestCaseSource("gameNames")]
        //[Parallelizable(ParallelScope.Children)]
        public void GameRatingOnPage_MatchesDefinitionInModel(string gameName)
        {
            new GamesPage(Driver.Current).GoTo().GameDetailsByName(gameName).Click();
            var gameDetails = new GameDetailsPage(Driver.Current);

            var game = gameDetails.GetBaseGame();
            var uncharted2 = new InMemoryGameService().GetGameByName(gameName);
            
            Assert.That(game.Genre, Is.EqualTo(uncharted2.Genre));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Quit();
        }
    }
}