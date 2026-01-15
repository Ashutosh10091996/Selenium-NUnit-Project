using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void login(string username , string password1)
        {
            UserName.Clear();
            UserName.SendKeys(username);

            password.Clear();
            password.SendKeys(password1);
            loginbutton.Click();
        }

    }
}
