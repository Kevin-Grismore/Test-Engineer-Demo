using System;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Selenium
{
    public static class Driver{
        [ThreadStatic]
        public static IWebDriver _driver;

        public static void Init()
        {               
            var co = new ChromeOptions();
            co.AddArgument("headless");
            co.AddArgument("no-sandbox");
            co.AcceptInsecureCertificates = true;
            co.PageLoadStrategy = PageLoadStrategy.Normal;
            _driver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"), co);
        }

        public static IWebDriver Current => _driver ?? throw new NullReferenceException("_driver is null");

        public static void GoTo(string url)
        {
            Current.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            Current.Quit();
        }

        public static IWebElement FindElement(By by)
        {
            return Current.FindElement(by);
        }

        public static IList<IWebElement> FindElements(By by)
        {
            return Current.FindElements(by);
        }
    }
}