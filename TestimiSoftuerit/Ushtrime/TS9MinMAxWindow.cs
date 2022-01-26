using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Ushtrime
{
    class TS9MinMAxWindow
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://dribbble.com/");
        }

        [Test]
        public void TestWindowMinimize()
        {
            Driver.driver.Manage().Window.Minimize();
            var dm = Driver.driver.Manage().Window.Size;
            int relativemaxheight = 744;
            int relativemaxwidth = 1382;
            Assert.IsTrue(dm.Height < relativemaxheight && dm.Width < relativemaxwidth);
        }
        [Test]
        public void TestWindowMaximize()
        {
            Driver.driver.Manage().Window.Maximize();
            var dm = Driver.driver.Manage().Window.Size;
            int relativemaxheight = 744;
            int relativemaxwidth = 1382;
            Assert.IsTrue(dm.Height == relativemaxheight && dm.Width == relativemaxwidth);
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
    }
}
