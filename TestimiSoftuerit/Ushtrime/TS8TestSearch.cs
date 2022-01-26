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
    class TS8TestSearch
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://dribbble.com/search");
        }

        [Test]
        public void SearchSocialMedia()
        {
            IWebElement searchInput = Driver.driver.FindElement(By.Id("search"));
            searchInput.SendKeys("Social Media");
            searchInput.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(5000);

            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("wrap-inner"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("shot-thumbnail-container"));
            Assert.IsTrue(productTitles.Count > 0);
        }
      
        [Test]
        public void SearchBanners()
        {           
            IWebElement searchInput = Driver.driver.FindElement(By.Id("search"));
            searchInput.SendKeys("Banners");
            searchInput.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(5000);

            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("wrap-inner"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("shot-thumbnail-container"));         
            Assert.IsTrue(productTitles.Count>0);
            
        }
       
        [Test]
        public void SearchWebDesign()
        {
            IWebElement searchInput = Driver.driver.FindElement(By.Id("search"));
            searchInput.SendKeys("Web Design");
            searchInput.SendKeys(Keys.Enter);

            System.Threading.Thread.Sleep(5000);

            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("wrap-inner"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("shot-thumbnail-container"));
            Assert.IsTrue(productTitles.Count > 0);
        }

    }
}
