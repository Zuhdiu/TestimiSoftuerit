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
    class TS9TestimiSearchTelegraf
    {

        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://jobs.telegrafi.com/");
        }

        [Test]
        public void TestVendi()
        {

            IWebElement emailInput = Driver.driver.FindElement(By.Name("q"));
            emailInput.SendKeys("Remote");
            Driver.driver.FindElement(By.Id("webpushr-deny-button")).Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='searchForm']/div[3]")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='vendi']/optgroup[2]/option[1]")).Click();
            Driver.driver.FindElement(By.ClassName("searchButton")).Click();

           IWebElement contanier = Driver.driver.FindElement(By.XPath("/html/body/section/div[2]/div/div[1]"));
           IReadOnlyCollection<IWebElement> productTitles = contanier.FindElements(By.TagName("li"));
            foreach (IWebElement title in productTitles)
            {
                var itemTitle = title.FindElement(By.TagName("strong"));
                var vendi = title.FindElement(By.ClassName("puna-location"));
                string a = itemTitle.Text;
                string b = vendi.Text;

                Assert.IsTrue(itemTitle.Text.Contains("Remote") && vendi.Text.Contains("Tiranë"));
            }
        }

        [Test]
        public void TestKategoria()
        {

            IWebElement emailInput = Driver.driver.FindElement(By.Name("q"));
            emailInput.SendKeys("Remote");
            Driver.driver.FindElement(By.Id("webpushr-deny-button")).Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='kategoria']")).Click();
            Driver.driver.FindElement(By.XPath("//*[@id='kategoria']/option[24]")).Click();
            Driver.driver.FindElement(By.ClassName("searchButton")).Click();

            IWebElement contanier = Driver.driver.FindElement(By.ClassName("daysBefore"));
            IReadOnlyCollection<IWebElement> productTitles = contanier.FindElements(By.TagName("li"));
            foreach (IWebElement title in productTitles)
            {
                var itemTitle = title.FindElement(By.TagName("strong"));

                Assert.IsTrue(itemTitle.Text.Contains("Remote"));
            }
        }
    }
}
