using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium_NUnit.Page_Objects
{

    public class Add_to_Cart_Page
    {
        private IWebDriver driver;
        private WebDriverWait Wait;
        public Add_to_Cart_Page(IWebDriver driver)
        {
            this.driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }


        private IWebElement backpack => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-sauce-labs-backpack")));
        public void BagPack()
        {
            backpack.Click();
        }
        private IWebElement BackLight => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-sauce-labs-bike-light")));
        public void backlight()
        {
            BackLight.Click();
        }
        private IWebElement TShirt => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-sauce-labs-bolt-t-shirt")));
        public void tshirt()
        {
            TShirt.Click();
        }
        private IWebElement Jacket => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-sauce-labs-fleece-jacket")));
        public void jacket()
        {
            Jacket.Click();
        }
        private IWebElement onisie => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-sauce-labs-onesie")));
        public void Onisie()
        {
            onisie.Click();
        }
        private IWebElement RedTshirt => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-test.allthethings()-t-shirt-(red)")));
        public void redTshirt()
        {
            RedTshirt.Click();
        }
        private IWebElement CartButton => Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='shopping_cart_link']")));
        public void cartButton()
        {
            CartButton.Click();
        }

    }     
}
