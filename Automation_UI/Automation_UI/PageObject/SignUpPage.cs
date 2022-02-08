using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace Automation_UI.PageObject
{
    public class SignUpPage : StartPage
    {
        public SignUpPage(IWebDriver driver) : base(driver)
        {
        }
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement inputEmailField_SignUp { get; set; }  //*[@id='email']
        [FindsBy(How = How.XPath, Using = "//*[@class='js-continue-button signup-continue-button form-control px-3 width-full width-sm-auto mt-4 mt-sm-0']")]
        private IWebElement clickButton_Continue { get; set; }
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement inputPasswordField_SignUp { get; set; } //*[@id ="password"]
        [FindsBy(How = How.XPath, Using = "//*[@class='js-continue-button signup-continue-button form-control px-3 width-full width-sm-auto mt-4 mt-sm-0']")]
        private IWebElement clickButton_ContinueSignUp { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id ='login']")]
        private IWebElement inputUserNameField_SignUp { get; set; }
        [FindsBy(How = How.Id, Using = "opt_in")]
        private IWebElement receiveUpdatesField { get; set; } //  if with "y" or "n"
        [FindsBy(How = How.XPath, Using = "//*[@class ='js -continue-button signup -continue-button form - control px - 3 width - full width - sm - auto mt - 4 mt - sm - 0']")]
        private IWebElement clickButtonContinue { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id ='home_children_button']")]
        private IWebElement checkButton_Person { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class ='ChallengeSelectableOverlay__StyledElement-sc-6lu34v-0 doRXGA']")]
        private IWebElement clickPicture { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@class ='form-control signup-submit-button width-full py-2 js-octocaptcha-form-submit']")]
        private IWebElement clickButtonAtTheEnd_CreateAccount { get; set; }

        public MainPage SignUp()
        {
            inputData(inputEmailField_SignUp, "");
            inputData(inputPasswordField_SignUp, "");
            clickButton_ContinueSignUp.Click();
            inputData(inputUserNameField_SignUp, "");
            AnswerToReceiveUpdates(receiveUpdatesField, "");
            clickButtonContinue.Click();
            checkButton_Person.Click();
            clickPicture.Click();
            clickButtonAtTheEnd_CreateAccount.Click();
            return new MainPage(driver);
        }


    }


}
