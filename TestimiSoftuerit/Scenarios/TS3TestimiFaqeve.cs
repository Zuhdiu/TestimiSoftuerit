using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS3TestimiFaqeve
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.neptun-ks.com/");
        }


        [Test]
        public void TestPageOfertat()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='mainNMenu']/ul/li[2]/a")).Click();
            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle != "https://www.neptun-ks.com/");


        }

        [Test]
        public void TestPageServisi()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='services']/a")).Click();
            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle != "https://www.neptun-ks.com/");
        }
    }
}
