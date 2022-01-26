using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS10TestEdito
    {

        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://jobs.telegrafi.com/login");
        }
        [Test]
        public void TestAddCV()
        {

            IWebElement emailInput = Driver.driver.FindElement(By.XPath("//*[@id='public-page']/div/div/div/div/div[2]/div/form/input[1]"));
            emailInput.SendKeys("zuhdi.krasniqi@gmail.com");
            IWebElement passlInput = Driver.driver.FindElement(By.XPath("//*[@id='public-page']/div/div/div/div/div[2]/div/form/input[2]"));
            passlInput.SendKeys(Config.password);
            Driver.driver.FindElement(By.ClassName("register-submit")).Click();

            Driver.driver.FindElement(By.XPath("//*[@id='main']/app-dashboard/div[1]/div/app-person-overview/div/app-saved-cv/div/div/div/div/button")).Click();
            IWebElement fbInput = Driver.driver.FindElement(By.Id("resumeTitle"));
            fbInput.SendKeys("Test");
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.ClassName("save-cv")).Click();
            Thread.Sleep(2000);
            var fb = Driver.driver.FindElement(By.ClassName("saved-cv"));
            string hreff = fb.GetAttribute("class");
            Assert.IsTrue(hreff.Equals("saved-cv"));

        }

        [Test]
        public void TestEditProfil()
        {

            IWebElement emailInput = Driver.driver.FindElement(By.XPath("//*[@id='public-page']/div/div/div/div/div[2]/div/form/input[1]"));
            emailInput.SendKeys("zuhdi.krasniqi@gmail.com");
            IWebElement passlInput = Driver.driver.FindElement(By.XPath("//*[@id='public-page']/div/div/div/div/div[2]/div/form/input[2]"));
            passlInput.SendKeys("Config.password");
            Driver.driver.FindElement(By.ClassName("register-submit")).Click();

            Driver.driver.FindElement(By.ClassName("edit-profile")).Click();
            IWebElement fbInput = Driver.driver.FindElement(By.Id("fb"));
            fbInput.SendKeys("https://www.facebook.com/zuhdi.17/");
            Driver.driver.FindElement(By.ClassName("save-bt")).Click();

            var fb = Driver.driver.FindElement(By.XPath("//*[@id='main']/app-dashboard/div[1]/div/app-person-overview/app-profile-widget/div/div/div/div/a"));
            string hreff = fb.GetAttribute("href");
            Assert.IsTrue(hreff == "https://www.facebook.com/zuhdi.17/");

        }
    }
}
