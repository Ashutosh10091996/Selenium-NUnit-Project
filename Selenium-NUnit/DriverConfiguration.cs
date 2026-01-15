using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_NUnit.BaseFolder;
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
            Driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";

        }
        [TearDown]
        public void closeBowser()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
