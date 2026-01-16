using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_NUnit.Page_Objects
{
    public class Swag_Lab
    {
        private IWebDriver driver;
        private WebDriverWait Wait;      
        public Swag_Lab(IWebDriver driver)
        {
            this.driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        private IWebElement continue_Shopping  => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("continue-shopping")));
        public void continueShopping()
        {
            continue_Shopping.Click();
        }
        private IWebElement checkOut => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("checkout")));
        public void check_Out()
        {
            checkOut.Click();
        }

    }
}
