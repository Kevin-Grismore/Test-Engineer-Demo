using System.IO;
using Games.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Games.UITests
{
    public class GameUITests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            var co = new ChromeOptions();
            co.AddArgument("headless");
            co.AddArgument("no-sandbox");
            co.AcceptInsecureCertificates = true;
            co.PageLoadStrategy = PageLoadStrategy.Normal;
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"), co);
            driver.Url = "https://localhost:5001/";
        }

        // 1. Go to Games page
        // 2. Assert Uncharted is displayed
        [Test]
        public void UnchartedIsOnGamesPage()
        {
            var gamesPage = new GamesPage(driver);
            gamesPage.GoTo();
            IWebElement uncharted = gamesPage.GameDetailsByName("Uncharted");
            Assert.That(uncharted.Displayed);
        }

        // 1. Go to Games page
        // 2. Click the Details link for Uncharted
        // 3. Assert that Uncharted's rating is T
        [Test]
        public void UnchartedIsRatedT()
        {
            new GamesPage(driver).GoTo().GameDetailsByName("Uncharted").Click();
            var gameDetails = new GameDetailsPage(driver);
            var rating = gameDetails.GetGameRating();
            Assert.That(rating, Is.EqualTo("T"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}