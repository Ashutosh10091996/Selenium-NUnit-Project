using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_NUnit.BaseFolder;
using Selenium_NUnit.Page_Objects;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium_NUnit
{
    public class BrowserConfigue : Base
    {
     
        [Test]
        public void urlCheck()
        {
            Driver.Url = "https://www.saucedemo.com/";
            loginPage LoginPage = new loginPage(Driver);
            LoginPage.login("standard_user", "secret_sauce");

        }
        [TearDown]
        public void closeBowser()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
