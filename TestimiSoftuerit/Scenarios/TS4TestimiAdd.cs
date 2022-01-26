using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS4TestimiAdd
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.neptun-ks.com/");
        }

        [Test]
        public void TestAddWishList()
        {
            LogIn();
            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("product-list-item-grid"));
            resultsContainer.FindElement(By.XPath("//*[@id='mainContainer']/div/div[3]/div[3]/div[1]/div/div/div[3]")).Click();

            var testim = Driver.driver.FindElement(By.CssSelector("#wishlist-app > a > i"));
            string b = testim.Text;
            Assert.IsTrue(b.Equals("2"));
        }

        [Test]
        public void TestAddCart()
        {
            LogIn();
            Thread.Sleep(2000);
            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("product-list-item-grid"));
           // IWebElement elem = resultsContainer.FindElement(By.XPath("/html/body/form/div[3]/div[3]/div/div[2]/div/div/div/div[2]/div/div/div/div[3]/div[3]/div[1]/div/div/div[3]/div[1]/a"));
            IWebElement elem = Driver.driver.FindElement(By.ClassName("btn--primary__icon-cart"));
           // elem = Driver.driver.SwitchTo().ActiveElement();
            Thread.Sleep(2000);
            elem.Click();

            var testim = Driver.driver.FindElement(By.CssSelector("#ctl00_ctl00_ctl00_cmscontent_WebShopMiniCart_app > a > i"));
            string a = testim.Text;
            Assert.IsTrue(a.Equals("2"));

        }

        public void LogIn()
        {
            Driver.driver.FindElement(By.ClassName("user_not_logged_system")).Click();

            IWebElement emailInput = Driver.driver.FindElement(By.XPath("//*[@id='authapp']/login/div/div/div/div[1]/div[1]/input"));
            emailInput.SendKeys("zuhdi.krasniqi@gmail.com");
            IWebElement passlInput = Driver.driver.FindElement(By.XPath("//*[@id='authapp']/login/div/div/div/div[1]/div[2]/input"));
            passlInput.SendKeys(Config.password);
            Driver.driver.FindElement(By.ClassName("btn-login")).Click();

             System.Threading.Thread.Sleep(2000);

            Driver.driver.FindElement(By.Id("neptunMain")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='neptunMain']/ul/li[2]/a")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='neptunMain']/ul/li[2]/ul/li[1]/a")).Click();
        }
    }
}
