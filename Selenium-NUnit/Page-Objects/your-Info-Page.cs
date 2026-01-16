using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_NUnit.Page_Objects
{
    public class your_Info_Page
    {
        private IWebDriver driver;
        private WebDriverWait Wait;
        public your_Info_Page(IWebDriver driver)
        {
            this.driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement first_name => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("first-name")));
        private IWebElement Last_name => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("last-name")));

        private IWebElement Zip_Code => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("postal-code")));

        private IWebElement cancel => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("cancel")));

        private IWebElement Continue => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("continue")));

        private IWebElement Menu => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("react-burger-menu-btn")));

        private IWebElement Cart => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='shopping_cart_link']")));
        public void FirstName(String F_Name)
        {
            first_name.SendKeys(F_Name);
        }
        public void last_name(String L_Name)
        {
            Last_name.SendKeys(L_Name);
        }
        public void zip_Code(String ZipCode)
        {
            Zip_Code.SendKeys(ZipCode);
        }
        public void continue_Btn()
        {
            Continue.Click();
        }
        public void Cancel_Btn()
        {
            cancel.Click();
        }

    }
}
