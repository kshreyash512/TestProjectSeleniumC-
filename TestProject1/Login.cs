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
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            driver.Manage().Window.Maximize();

            IWebElement webElement = driver.FindElement(By.Id("loginLink"));

            webElement.Click();

            IWebElement webElementUserNameTextField = driver.FindElement(By.XPath("//input[@id='UserName']"));
            webElementUserNameTextField.SendKeys("admin");

            IWebElement webElementPasswordTextField = driver.FindElement(By.XPath("//input[@id='Password']"));
            webElementPasswordTextField.SendKeys("password");

            IWebElement rememberMe = driver.FindElement(By.Id("RememberMe"));

            bool isChecked = rememberMe.Selected;

            Assert.IsFalse(isChecked, "The Remember Me checkbox is not selected on the page.");

            webElementPasswordTextField.SendKeys(Keys.Enter);

        }
    }
}