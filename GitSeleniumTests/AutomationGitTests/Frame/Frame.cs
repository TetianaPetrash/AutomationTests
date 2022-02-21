using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutomationGitTests.Frame
{
    public class Frame<TWebDriver> where TWebDriver : IWebDriver, new() //нужен для того,чтобы класс тестов наследовался 
    {
        private WebDriverWait wait;
        protected IWebDriver driver;
        private readonly string url = "https://github.com/";

        [SetUp]
        public void FixtureSetUp()
        {
            var options = new ChromeOptions();
            options.AddArguments("--no-sandbox");
            this.driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [OneTimeTearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }

       
    }
}
