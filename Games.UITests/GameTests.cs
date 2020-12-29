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
            var co = new ChromeOptions();
            co.AddArgument("headless");
            co.AcceptInsecureCertificates = true;
            co.PageLoadStrategy = PageLoadStrategy.Normal;
            co.AddArgument("no-sandbox");
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"), co);
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