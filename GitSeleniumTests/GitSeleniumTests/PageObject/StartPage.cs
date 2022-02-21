using AutomationUi.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Linq;

namespace AutomationUi.PageObject
{
    public class StartPage : BasePage
    {
        public StartPage(IWebDriver driver) : base(driver) //берем driver и перекидываем его в base(driver)
        {
        }
        private IWebElement button_SignIn => driver.FindElement(By.XPath("//*[@class='HeaderMenu-link flex-shrink-0 no-underline']")); //authorization
        //private IWebElement button_SignIn => driver.FindElement(By.XPath("//div[contains(@class,'position-relative')]/a[contains(@href,'/login')]"));
        private IWebElement button_SignUp => driver.FindElement(By.XPath("//*[@class='HeaderMenu-link flex-shrink-0 d-inline-block no-underline border color-border-default rounded px-2 py-1']"));
        // private IWebElement button_SignUp => driver.FindElement(By.XPath("//div[contains(@class,'d-lg-flex')]/a[contains(@href,'/signup')]"));
        private IWebElement inputSearchField => driver.FindElement(By.XPath("//*[@class= 'form-control input-sm header-search-wrapper p-0 js-chromeless-input-container header-search-wrapper-jump-to position-relative d-flex flex-justify-between flex-items-center']"));
        //private IWebElement inputSearchField => driver.FindElement(By.XPath("//div[contains(@class,'position-relative')]//input[contains(@type,'text')]"));
        private IWebElement clickButtonExplore => driver.FindElement(By.XPath("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]//*[contains(@class, 'icon-chevon-down-mktg')]"));
        private List<IWebElement> listOFElementsExplore => driver.FindElements(By.XPath("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]/following-sibling::div[contains(@class, 'dropdown-menu')]//li")).ToList();
        private IWebElement clickButtonPricing => driver.FindElement(By.XPath("//summary[contains(@class,'HeaderMenu') and contains(text(),'Pricing')]"));
        private List<IWebElement> listOFElementsPricing => driver.FindElements(By.XPath("//summary[contains(@class,'HeaderMenu-summary') and contains(text(),'Pricing')]/following-sibling::div[contains(@class,'dropdown-menu')]//li")).ToList();
        //private IWebElement clickButtonTeam => driver.FindElement(By.XPath("//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']"));
        //private IWebElement clickButtonEnterprise => driver.FindElement(By.XPath("//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']"));
        //private IWebElement clickButtonMarketplace => driver.FindElement(By.XPath("//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']"));


        public SignInPage SignIn()
        {
            button_SignIn.Click();
            return new SignInPage(driver);
        }

        public SignUpPage ClickSignUp()
        {
            button_SignUp.Click();
            return new SignUpPage(driver);
        }

        public SearchPage GetSearchInfo()
        {
            inputSearchField.SendKeys("new" + Keys.Enter);
            return new SearchPage(driver);
        }

        public ExplorePage GetExploreInfo()
        {
            clickButtonExplore.Click();
            return new ExplorePage(driver);
        }

        public ExplorePage SelectExploreListOfElements()
        {
            clickButtonExplore.Click();
            IsElementClicable("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]/following-sibling::div[contains(@class, 'dropdown-menu')]//li");
            IWebElement nameElement = driver.FindElement(By.XPath("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]/following-sibling::div[contains(@class, 'dropdown-menu')]//li[3]"));
            var result = GetText(listOFElementsExplore, nameElement);
            result.Click();
            if (result != null)
                return new ExplorePage(driver);
            throw new System.Exception(nameof(result)); //nameof(result) -result будет в ошибке,если не найдет
        }

        public ExplorePage TestActionClass()
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(inputSearchField,"new" + Keys.Enter).Perform();
           return new ExplorePage(driver);
        }

        public ExplorePage SelectListOfElements()
        {
            IWebElement nameElement = driver.FindElement(By.XPath("//summary[contains(@class, 'HeaderMenu-summary') and contains(text(), 'Explore')]/following-sibling::div[contains(@class, 'dropdown-menu')]//li[3]"));
            Actions builder = new Actions(driver);
            var result = GetText(listOFElementsExplore, nameElement);
            if (result != null)
            {
                builder.MoveToElement(clickButtonExplore).Click(nameElement).Build().Perform();
            }
            return new ExplorePage(driver);
        }





        }
}
