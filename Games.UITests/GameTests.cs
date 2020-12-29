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
            co.AddArgument("no-sandbox");
            co.AcceptInsecureCertificates = true;
            co.PageLoadStrategy = PageLoadStrategy.Normal;
            driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"), co);
        }

        // 1. Go to Games page
        // 2. Assert Uncharted is displayed
        [Test]
        public void UnchartedIsOnGamesPage()
        {
            driver.Url = "https://localhost:5001/games";
            var uncharted = driver.FindElement(By.CssSelector("td[id='Uncharted']"));
            Assert.That(uncharted.Displayed);
        }

        [Test]
        public void UnchartedIsRatedT()
        {
            driver.Url = "https://localhost:5001/games";
            driver.FindElement(By.CssSelector("a[href*='Details/1']")).Click();
            var unchartedRating = driver.FindElement(By.CssSelector("dd[id='rating-desc']")).Text;
            Assert.That(unchartedRating, Is.EqualTo("T"));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}