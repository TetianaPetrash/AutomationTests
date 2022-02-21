using OpenQA.Selenium;


namespace AutomationUi.PageObject
{
    public class SignInPage : StartPage
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {
        }       
        private IWebElement inputUsernameField_SignIn => driver.FindElement(By.XPath("//*[@id='login_field']"));
        private IWebElement inputpassword_SignIn => driver.FindElement(By.Id("password"));
        private IWebElement clickButton_SignIn => driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-block js-sign-in-button']"));
        private IWebElement clickButton_CreateAccaunt => driver.FindElement(By.XPath("//*[text()='Create an account']"));

        public MainPage SignInToAccount()
        {
            InputData(inputUsernameField_SignIn, "tanuhatim@gmail.com");
            InputData(inputpassword_SignIn, "1992Vfhbyf92");
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


