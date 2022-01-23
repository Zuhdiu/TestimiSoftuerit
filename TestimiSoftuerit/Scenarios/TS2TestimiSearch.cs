using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS2TestimiSearch
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.neptun-ks.com/");
        }

        [Test]
        public void SearchDell()
        {
            IWebElement searchInput = Driver.driver.FindElement(By.XPath("/html/body/form/div[3]/div[1]/header/div[2]/div/div[2]/div[2]/div/div/div/div/input[2]"));
            searchInput.SendKeys("Dell");
            Driver.driver.FindElement(By.ClassName("site-search__button")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl01_ctl00_SearchProductResultId']/div/div/div[2]"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("product-list-item__content--title"));
            foreach (IWebElement title in productTitles)
            {
                // string itemTitle = title.GetAttribute("text").ToLower();
                Assert.IsTrue(title.Text.ToUpper().Contains("DELL"));
            }
        }
        [Test]
        public void SearchApple()
        {
            IWebElement searchInput = Driver.driver.FindElement(By.XPath("/html/body/form/div[3]/div[1]/header/div[2]/div/div[2]/div[2]/div/div/div/div/input[2]"));
            searchInput.SendKeys("Apple");
            Driver.driver.FindElement(By.ClassName("site-search__button")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.XPath("//*[@id='ctl00_ctl00_ctl00_cmscontent_CmsMain_ctl01_ctl00_SearchProductResultId']/div/div/div[2]"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("product-list-item__content--title"));
            foreach (IWebElement title in productTitles)
            {
                // string itemTitle = title.GetAttribute("text").ToLower();
                Assert.IsTrue(title.Text.ToUpper().Contains("APPLE"));
            }
        }
    }
}
