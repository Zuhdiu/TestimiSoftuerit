using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS7TestimiPagination
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://telegrafi.com/");
        }

        [Test]
        public void TestMore()
        {
            Driver.driver.FindElement(By.ClassName("btn-meshume-fokusi")).Click();
            System.Threading.Thread.Sleep(5000);
            IWebElement resultsContainer = Driver.driver.FindElement(By.XPath("/html/body/div[8]/div/div[1]/div[5]/div[2]"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("fokusArticle"));
            Assert.IsTrue(productTitles.Count > 17);
        }

        [Test]
        public void TestNext()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[10]/div/div/div/div/div[1]/div/div[1]")).Click();
            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("dealsSwiper"));
            IReadOnlyCollection<IWebElement> productTitles = resultsContainer.FindElements(By.ClassName("swiper-slide"));
           string a = productTitles.First().GetAttribute("class");
           Assert.IsTrue(a.Contains("prev"));
        }
    }
}
