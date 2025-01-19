using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Window.Maximize();

            IWebElement webElement = driver.FindElement(By.Name("q"));

            webElement.SendKeys("Selenium");

            webElement.SendKeys(Keys.Return);
        }
    }
}