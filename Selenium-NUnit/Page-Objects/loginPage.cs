using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using NUnit.Framework;

namespace Selenium_NUnit.Page_Objects
{
    public class loginPage
    {
        private IWebDriver driver;
        private WebDriverWait Wait;
        public loginPage(IWebDriver driver)
        {
            this.driver = driver;
            this.Wait = new WebDriverWait(driver , TimeSpan.FromSeconds(10));
        }

        private IWebElement UserName => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user-name")));
        private IWebElement password => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
        private IWebElement loginbutton => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login-button")));

        public void login()
        {
            string DriverUrl = ConfigurationManager.AppSettings["DriverURL"];
            driver.Navigate().GoToUrl(DriverUrl);
            string Expected_URL = ConfigurationManager.AppSettings["ActualURL"];
            UserName.Clear();
            UserName.SendKeys(ConfigurationManager.AppSettings["UserName"]);

            password.Clear();
            password.SendKeys(ConfigurationManager.AppSettings["Password"]);
            loginbutton.Click();
            try
            {
                string actualURL = driver.Url;
                if (actualURL == Expected_URL)
                {
                    Assert.That(actualURL, Is.EqualTo(Expected_URL) , "Login URL matched");
                    TestContext.Progress.WriteLine("Login Successful Expected URL found" + Expected_URL);
                }
                else
                {
                    Assert.Fail("Expected LOGIN URL not found" + Expected_URL);
                    TestContext.Progress.WriteLine("Wrong URL found");
                }
            }
            catch(Exception ex)
            {
                TestContext.Progress.WriteLine("Unhandled Exception occured" + ex);
            }
           
        }

    }
}
