using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS1Filtrimi
    {            
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.neptun-ks.com/pocetna/categories/IT___Lojera/Laptop.nspx");
        }


        [Test]
        public void FilterBrand()
        {       
            Driver.driver.FindElement(By.XPath("//*[@id='mainContainer']/div/div[1]/aside/div[1]/div/div[2]/div/div/ul/li[2]/div/a")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.XPath("//*[@id='mainContainer']/div/div[3]"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("product-list-item__content--title"));
            foreach (IWebElement title in productTitles)
            {
                string itemTitle = title.Text;
                Assert.IsTrue(title.Text.Contains("DELL"));
            }
        }

        [Test]
        public void FilterCmimit()
        {
            //Driver.driver.FindElement(By.XPath("//*[@id='mainContainer']/div/div[1]/aside/div[1]/div/div[2]/div/div/ul/li[2]/div/a")).Click();
            IWebElement element = Driver.driver.FindElement(By.XPath("//*[@id='affix2']/div/div[1]/div[3]/select"));
          

            var selectElement = new SelectElement(element);
            selectElement.SelectByValue("number:3");

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.EndsWith("3"));

        }
    }
}
