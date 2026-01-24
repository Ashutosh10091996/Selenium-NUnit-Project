using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_NUnit.Page_Objects
{
    public class CheckoutReviewPage
    {
        private IWebDriver driver;
        private WebDriverWait Wait;
        public CheckoutReviewPage(IWebDriver driver)
        {
            this.driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement finish_btn => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("finish")));
        private IWebElement cancel_btn => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("cancel")));
        public class find_product_Count()
        {
            
        }


    }
}
