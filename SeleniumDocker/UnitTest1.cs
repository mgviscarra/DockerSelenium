using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumDocker
{
    [TestFixture]
    [Parallelizable]
    public class GoogleTest1:DriverFactory
    {
        [Test, TestCaseSource(typeof(BrowserTypes), "Drivers")]
        public void BrowseSeleniumTest(BrowserType driver)
        {
            ChooseDriverInstance(driver);
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                "The text selenium does not exist");
            Driver.Quit();
        }
    }

    [TestFixture]
    [Parallelizable]
    public class GoogleTest2 : DriverFactory
    {

        [Test, TestCaseSource(typeof(BrowserTypes), "Drivers")]
        public void BrowseTruextendTest(BrowserType driver)
        {
            ChooseDriverInstance(driver);
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Truextend");
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            Assert.That(Driver.PageSource.Contains("Truextend"), Is.EqualTo(true),
                "The text Truextend does not exist");
            Driver.Quit();
        }
    }
}

