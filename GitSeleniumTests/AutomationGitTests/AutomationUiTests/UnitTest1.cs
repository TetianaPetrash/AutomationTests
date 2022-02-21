using AutomationGitTests.Frame;
using AutomationUi.Models;
using AutomationUi.PageObject;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;

namespace AutomationGitTests.AutomationUiTests
{
    [TestFixture(typeof(ChromeDriver))]
    class Tests<TWebDriver> : Frame<TWebDriver> where TWebDriver : IWebDriver, new()
    {
        StartPage startPage = null;
        MainPage mainPage = null;
        SignInPage signPage = null;
        SearchPage searchPage = null;
        SignUpPage signUpPage = null;
        ExplorePage explorePage = null;
        private List<IWebElement> listOFElements => driver.FindElements(By.XPath("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]/following-sibling::div[contains(@class, 'dropdown-menu')]//li")).ToList();

        [Test]
        public void Authorization()
        {
            startPage = new StartPage(driver);
            signPage = startPage.SignIn();
            signPage.SignInToAccount();
        }

        [Test]
        public void GetSearchInfo()
        {
            startPage = new StartPage(driver);
            searchPage = startPage.GetSearchInfo();
        }

        [Test]
        public void CreateAccount() //не до конца работает из-за капчи
        {
            var newUser = new NewUser
            {
                Email = "",
                Password = "",
                NickName = ""
            };
            startPage = new StartPage(driver);
            signUpPage = startPage.ClickSignUp();
            signUpPage.SignUp(newUser);
        }

        [Test]
        public void ClickExploreGitHub()
        {
            startPage = new StartPage(driver);
            explorePage = startPage.GetExploreInfo();
        }

        [Test]
        public void SelectListOfExplore()
        {
            IWebElement element = driver.FindElement(By.XPath("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]/following-sibling::div[contains(@class, 'dropdown-menu')]//li[3]"));
            startPage = new StartPage(driver);
            explorePage = startPage.SelectExploreListOfElements();
        }

        [Test]
        public void SearchInfoUseActionClass() //тест с исп класса Action
        {
            startPage = new StartPage(driver);
            explorePage = startPage.TestActionClass();
        }

        [Test]
        public void SelectElementFromListExplore() //тест с исп класса Action
        {
            startPage = new StartPage(driver);
            explorePage = startPage.SelectListOfElements();
        }


    }
}