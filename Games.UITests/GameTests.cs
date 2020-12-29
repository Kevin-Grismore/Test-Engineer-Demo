using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Games.UITests
{
    public class GameTests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        }

        // 1. Go to Games page
        // 2. Assert Uncharted is displayed
        [Test]
        public void UnchartedIsOnGamesPage()
        {
            driver.Url = "https://localhost:5001/games";
            var uncharted = driver.FindElement(By.CssSelector("a[class='navbar-brand']"));
            Assert.That(uncharted.Displayed);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}