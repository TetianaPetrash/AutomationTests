using AutomationUi.Models;
using OpenQA.Selenium;



namespace AutomationUi.PageObject
{
 public class SignUpPage : StartPage
    {
        public SignUpPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement inputEmailField_SignUp => driver.FindElement(By.XPath("//*[@class='js-continue-input js-continue-focus-target signup-input form-control input-block flex-1 border-0 rounded-0 p-0 box-shadow-none color-text-white f4 text-mono']"));  //*[@id='email']
        private IWebElement clickButton_Continue => driver.FindElement(By.XPath("//div[@id='email-container']//button[contains(text(), 'Continue')]"));
        //private IWebElement clickButton_Continue => driver.FindElement(By.XPath("//div[@id='email-container']//button[contains(text(), 'Continue')]);
        private IWebElement inputPasswordField_SignUp => driver.FindElement(By.Id("password")); //*[@id ="password"]
        private IWebElement clickButtonPassportContinue => driver.FindElement(By.XPath("//button[@data-optimizely-event='click.signup_continue.password']"));
        private IWebElement inputUserNameField_SignUp => driver.FindElement(By.XPath("//*[@id ='login']"));
        private IWebElement clickButtonUserNameContinue => driver.FindElement(By.XPath("//button[@data-optimizely-event='click.signup_continue.username']"));
        private IWebElement receiveUpdatesField => driver.FindElement(By.Id("opt_in"));
        private IWebElement clickButtonUpdatesContinue => driver.FindElement(By.XPath("//button[@data-optimizely-event='click.signup_continue.opt-in']"));
        private IWebElement checkButton_Person => driver.FindElement(By.XPath("//*[@href ='#']")); //*[@id='home_children_button']
        private IWebElement clickPicture => driver.FindElement(By.XPath("//*[@class ='ChallengeSelectableOverlay__StyledElement-sc-6lu34v-0 doRXGA']"));
        private IWebElement clickButtonAtTheEnd_CreateAccount => driver.FindElement(By.XPath("//*[@class ='form-control signup-submit-button width-full py-2 js-octocaptcha-form-submit']"));
        //private IWebElement welcomeinfo => driver.FindElement(By.XPath("//*[@class ='m - 4 p - 4 f4 color - shadow - small bg - gray - 800 - mktg rounded - 2 signup - content - container']"));
       
            
        
        
        public MainPage SignUp(NewUser newUser)
        {
            InputData(inputEmailField_SignUp, newUser.Email);
            IsElementClicable("//div[@id='email-container']//button[contains(text(), 'Continue')]");
            clickButton_Continue.Click();
            InputData(inputPasswordField_SignUp, newUser.Password);
            IsElementClicable("//button[@data-optimizely-event='click.signup_continue.password']");
            clickButtonPassportContinue.Click();
            InputData(inputUserNameField_SignUp, newUser.NickName);
            IsElementClicable("//button[@data-optimizely-event='click.signup_continue.username']");
            clickButtonUserNameContinue.Click();        
            receiveUpdatesField.SendKeys(newUser.Updates);
            IsElementClicable("//button[@data-optimizely-event='click.signup_continue.opt-in']");
            clickButtonUpdatesContinue.Click();
            checkButton_Person.Click(); // верный локатор,но не находит эл
            clickPicture.Click();
            clickButtonAtTheEnd_CreateAccount.Click();
            return new MainPage(driver);
        }
    }
}
