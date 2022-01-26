using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS14StokCmimi
    {

        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://gjirafamall.com/libra-3");
        }

        [Test]
        public void FilterStok()
        {
            //Driver.driver.FindElement(By.XPath("//*[@id='facet - body - quantity']/div/div/label")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='facet-body-quantity']/div/div/label")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("product-list-container"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("tjeraProductsCount"));
            foreach (IWebElement title in productTitles)
            {
                string itemTitle = title.GetAttribute("class");
                Assert.IsTrue(itemTitle.Contains("art-labels"));
            }
        }

        [Test]
        public void FilterCimiDeri()
        {
            IWebElement searchInput = Driver.driver.FindElement(By.Id("price-range-to"));
            searchInput.Clear();
            searchInput.SendKeys("10");
            Driver.driver.FindElement(By.Id("btn-custom-price-range")).Click();

            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("product-list-container"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("tjeraProductsCount"));
            foreach (IWebElement title in productTitles)
            {

                var priceItem = title.FindElement(By.ClassName("art-price"));

                string priceValue = priceItem.Text;

                priceValue.Trim(' ');
                priceValue.Trim(',');
                priceValue.Trim('€');
                priceValue.Trim('.');

                Assert.IsTrue(Double.Parse(priceValue) <= 10);

            }
        }
    }
}
