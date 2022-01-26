using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS13TestimiScroll
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://dribbble.com/");

            //Search
           // BrowserActions.InitializeDriver("https://dribbble.com/search");
        }


        [Test]
        public void TestScroll()
        {

            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("wrap-inner"));
            resultsContainer.FindElement(By.ClassName("shot-thumbnail-container")).Click();

            //System.Threading.Thread.Sleep(5000);
            //List<string> lstWindow = Driver.driver.WindowHandles.ToList();
            //Driver.driver.SwitchTo().Window(lstWindow[1]);

            IWebElement test = Driver.driver.FindElement(By.ClassName("color-palette-container"));
            //test.SendKeys(Keys.PageDown);
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver.driver;
            js1.ExecuteScript("arguments[0].scrollIntoView();", test);


            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
            js.ExecuteScript("window.scrollTo(0, 200)");
            var value = js.ExecuteScript("return window.pageYOffset;");
            Assert.IsTrue(value.ToString() == "200");
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
            Assert.IsTrue(productTitles.Count > 0);

        }
    }
}
