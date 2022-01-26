using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace TestimiSoftuerit.Scenarios
{

  public  class TS8TestimiButonaveSh
    {
        private string url = "https://telegrafi.com/te-kemi-endemi-ne-vend-te-pandemise/";
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver(url);
        }
   

        [Test, RequiresSTA]      
        public void TestCopyLink()
        {
            IWebElement element1= Driver.driver.FindElement(By.ClassName("tooltip"));
            element1.Click();
            string pasteText = Clipboard.GetText();
            Assert.IsTrue(url == pasteText);
        }

        [Test]
        public void TestShareFB()
        {
            Driver.driver.FindElement(By.ClassName("fb")).Click();

            List<string> lstWindow = Driver.driver.WindowHandles.ToList();
            Driver.driver.SwitchTo().Window(lstWindow[1]);

            IWebElement emailInput = Driver.driver.FindElement(By.Id("email"));
            emailInput.SendKeys("Email");
            IWebElement passlInput = Driver.driver.FindElement(By.Id("pass"));
            passlInput.SendKeys("Password");
            Driver.driver.FindElement(By.Name("login")).Click();
        }
    }
}
