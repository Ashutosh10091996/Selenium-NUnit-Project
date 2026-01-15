using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

    }
}
