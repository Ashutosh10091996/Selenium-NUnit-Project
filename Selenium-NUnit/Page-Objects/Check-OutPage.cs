using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_NUnit.Page_Objects
{
    public class Check_OutPage
    {
        private IWebDriver driver;
        private WebDriverWait Wait;
        public Check_OutPage(IWebDriver driver)
        {
            this.driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement CheckOut_Button => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("checkout")));
        public void CheckOutButton()
        {
            CheckOut_Button.Click();
        }
        private IWebElement BackToShopping => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("continue-shopping")));
        public void backtoShopping()
        {
            BackToShopping.Click();
        }

        private IWebElement RemoveButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("remove-sauce-labs-bike-light")));
        
        public void Removebuton()
        {
            RemoveButton.Click();
        }
    }
}
