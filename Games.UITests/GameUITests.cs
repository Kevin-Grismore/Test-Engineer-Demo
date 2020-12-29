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
            AllPages.Init();
            Driver.GoTo("https://localhost:5001/");
        }

        // 1. Go to Games page
        // 2. Assert Uncharted is displayed
        [Test]
        public void UnchartedIsOnGamesPage()
        {
            AllPages.Games.GoTo();
            IWebElement uncharted = AllPages.Games.GameDetailsByName("Uncharted");
            Assert.That(uncharted.Displayed);
        }

        // 1. Go to Games page
        // 2. Click the Details link for a game
        // 3. Assert that the game's rating matches the expected rating
        static string[] gameNames = { "Uncharted", "Uncharted 2" };
        [Test, Category("Games")]
        [TestCaseSource("gameNames")]
        [Parallelizable(ParallelScope.Children)]
        public void GameRatingOnPage_MatchesDefinitionInModel(string gameName)
        {
            AllPages.Games.GoTo().GameDetailsByName(gameName).Click();

            var gameOnPage = AllPages.GameDetails.GetBaseGame();
            var gameDefinition = new InMemoryGameService().GetGameByName(gameName);
            
            Assert.That(gameOnPage.Genre, Is.EqualTo(gameDefinition.Genre));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}