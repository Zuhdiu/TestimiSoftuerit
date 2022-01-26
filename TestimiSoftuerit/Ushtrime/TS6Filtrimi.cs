using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Ushtrime
{
    class TS6Filtrimi
    {

        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://dribbble.com/");
        }

        [Test]
        public void TestColorFilter()
        {           
            Driver.driver.FindElement(By.ClassName("filters-toggle-btn")).Click();
            IWebElement searchInput = Driver.driver.FindElement(By.Name("color"));
            searchInput.SendKeys("C69CF4");
            System.Threading.Thread.Sleep(1000);
            Driver.driver.FindElement(By.ClassName("filters-toggle-btn")).Click();

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.Contains("C69CF4"));
        }

        [Test]
        public void TestAppFilter()
        {
            Driver.driver.FindElement(By.ClassName("filters-toggle-btn")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='wrap']/div[3]/div[2]/form/fieldset[4]/span/a")).Click();
            
            System.Threading.Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath("//*[@id='wrap']/div[3]/div[2]/form/fieldset[4]/span/div/ul/li[2]")).Click();
            
            var testim = Driver.driver.FindElement(By.XPath("//*[@id='main']/ol/div/h3"));
            string b = testim.Text;
            Assert.IsFalse(b.Contains("No results found"));
        }
    }
}
