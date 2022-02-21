using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace AutomationUi.PageObject
{
    public abstract class BasePage //тип abstact - BasePage не существует, родитель, у которого нет объекта, в плане логики не нужно создавать ему объект
    { 
        
        protected IWebDriver driver;
        private IWebElement element;
        private WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

      

        public void InputData(IWebElement element, string data)
        {
            element.Clear();
            element.SendKeys(data);
        }

        internal void AnswerToReceiveUpdates(IWebElement element, string answer)
        {

            if (answer.Equals("y"))
            {
                element.SendKeys("y");
            }
            else
            {
                element.SendKeys("n");
            }
        }

        public bool IsElementClicable(string by)
        {
            try
            {                
                element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(by)));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IWebElement GetText(List<IWebElement> list, IWebElement name)
        {          
            foreach (var item in list)
            {
                if (item.Equals(name))
                {                  
                    return item;
                }
            }
            return null;
        }



    }
}
