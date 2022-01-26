using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Ushtrime
{
    class TS7TestButtons
    {
        [SetUp]
        public void Setup()
        {
            // TestJobButton
            //BrowserActions.InitializeDriver("https://dribbble.com/");
            // TestPostJobButton TestDesignerButton
            BrowserActions.InitializeDriver("https://dribbble.com/jobs");
        }

        [Test]
        public void TestJobButton()
        {
            IWebElement jobMenu = Driver.driver.FindElement(By.XPath("//*[@id='shots']/div[1]/div[1]/nav/ul/li[2]/a"));
            Actions hover = new Actions(Driver.driver);
            hover.MoveToElement(jobMenu).Perform();
           
            System.Threading.Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='shots']/div[1]/div[1]/nav/ul/li[2]/div/ul/div/li[1]/a")).Click();
           
            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.EndsWith("jobs"));
        }

        [Test]
        public void TestPostJobButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='content']/div/div[1]/div[1]/div/a[1]")).Click();

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.EndsWith("new"));

        }

        [Test]
        public void TestDesignerButton()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='content']/div/div[1]/div[1]/nav/ul/li[1]/a")).Click();

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.EndsWith("designers"));

        }


    }
}
