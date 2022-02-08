using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Automation_UI.PageObject
{
    public class StartPage : BasePage
    {
        public StartPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='HeaderMenu-link flex-shrink-0 no-underline']")]
        private IWebElement button_SignIn { get; set; } //authorization

        [FindsBy(How = How.XPath, Using = "//*[@class='HeaderMenu-link flex-shrink-0 d-inline-block no-underline border color-border-default rounded px-2 py-1']")]
        private IWebElement button_SignUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class ='form-control input-sm header-search-input jump-to-field js-jump-to-field js-site-search-focus']")]
        private IWebElement inputSearchField { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']")]
        //private IWebElement clickButtonTeam { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']")]
        //private IWebElement clickButtonEnterprise { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@class ='HeaderMenu-link no-underline py-3 d-block d-lg-inline-block']")]
        //private IWebElement clickButtonMarketplace { get; set; }

       // public void GetFieldSearchInfo() => driver.FindElement((By)inputSearchField).SendKeys("new" + Keys.Enter); переделать

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

        //public bool IsLogo()
        //{
        //    return SummaryDisplayed("");
        //}


    }


}
