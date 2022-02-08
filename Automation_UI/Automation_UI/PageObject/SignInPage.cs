using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Automation_UI.PageObject
{
    public class SignInPage : StartPage
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='login_field']")]
        private IWebElement inputUsernameField_SignIn { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement inputpassword_SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='btn btn-primary btn-block js-sign-in-button']")]
        private IWebElement clickButton_SignIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[text()='Create an account']")]

        private IWebElement clickButton_CreateAccaunt { get; set; }

        public MainPage SignInToAccount()
        {
            inputData(inputUsernameField_SignIn, "");
            inputData(inputpassword_SignIn, "");
            clickButton_SignIn.Click();
            return new MainPage(driver);
        }

        public SignUpPage CreateAccaunt()
        {
            clickButton_CreateAccaunt.Click();
            return new SignUpPage(driver);
        }
    }
}
