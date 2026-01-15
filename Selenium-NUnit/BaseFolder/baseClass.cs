using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WebDriverManager.DriverConfigs.Impl;





namespace Selenium_NUnit.BaseFolder
{
    /// <summary>
    /// class hold the driver info based on the browser 
    /// </summary>
    public class Base()
    {
        /// <summary>
        /// Global declaration of Driver
        /// </summary>
        public IWebDriver Driver;



        /// <summary>
        /// one time setup for Browser
        /// </summary>
        [SetUp]
        public void StartBrowser()
        {
            //this function fetch the data from Global configuration file 
         
            IniTBrowser(ConfigurationManager.AppSettings["Browser"]);
            Driver.Manage().Window.Maximize();
        }


        /// <summary>
        /// This function will choose the browser from app.configue nd launch it using driver
        /// </summary>
        /// <param name="BrowserName"></param>
        public void IniTBrowser(string BrowserName)
        {
            switch(BrowserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    Driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    Driver = new ChromeDriver();
                    break;
                case "Edge":
                    Driver = new EdgeDriver();
                    break;
            }
        }


        /// <summary>
        /// when test is completed this function will close the driver instace and release the memory
        /// </summary>
        [TearDown]
        public void closeBrowser()
        {
            Driver.Dispose();
            Driver.Quit();
        }
    }
}

