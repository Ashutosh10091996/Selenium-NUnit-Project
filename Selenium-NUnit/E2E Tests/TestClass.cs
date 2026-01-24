using Selenium_NUnit.BaseFolder;
using Selenium_NUnit.Page_Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Selenium_NUnit.E2E_Tests
{
    public class TestClass : Base
    {

        [Test]
        public void Check_Login()
        {
                     
            loginPage LoginPage = new loginPage(Driver);
            LoginPage.login();          
           
        }
        [Test]
        public void InventryPage_Add_Items()
        {

            Check_Login();
            Inventry_Page inventry_Page = new Inventry_Page(Driver);
            inventry_Page.BagPack();
            inventry_Page.tshirt();
            inventry_Page.jacket();
            inventry_Page.cartButton();
        }

        [Test]
        public void Count_added_items()
        {
            InventryPage_Add_Items();

        }
    }
}
