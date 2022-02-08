using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace Automation_UI.PageObject
{
    public abstract class BasePage
    {
        protected IWebDriver driver;
        private WebDriverWait wait;
        private IWebElement element;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public bool SummaryDisplayed(string by)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath(by))));
                return element.Displayed;
            }
            catch
            {
                return false;
            }
        }

        public void inputData(IWebElement element, string data)
        {
            element.Clear();
            element.SendKeys(data);
        }

        internal void AnswerToReceiveUpdates(IWebElement element, string answer) 
        {

            if (answer.Equals("y"))
            {
                driver.FindElement((By)element).SendKeys("y");
            }
            else
            {
                driver.FindElement((By)element).SendKeys("n");
            }
        }
    }
}
