using Automation_UI.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationUi_Tests
{
    [TestFixture(typeof(ChromeDriver))]
    class Tests<TWebDriver> : Frame<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        StartPage startPage = null;
        MainPage mainPage = null;
        SignInPage signPage = null;

        [Test]
        public void Authorization()
        {           
            startPage = new StartPage(driver);
            signPage = startPage.SignIn();
            signPage.SignInToAccount();
        }

        //[Test]
        //public void test()
        //{
        //    startPage = new StartPage(driver);
        //    if (startPage.IsLogo())
        //    {
        //        mainPage = startPage.SignIn(driver);
        //    }
        //    else
        //    {
        //        System.Diagnostics.Debug.WriteLine("Here");
        //    }

        //}


    }
}