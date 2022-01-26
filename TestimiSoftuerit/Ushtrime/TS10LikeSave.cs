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
    class TS10LikeSave
    {

        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://dribbble.com/");
        }

        [Test]
        public void TestLike()
        {
            Driver.driver.FindElement(By.XPath("//*[@id='shots']/div[2]/div[1]/ul/li[2]/a")).Click();

            IWebElement emailInput = Driver.driver.FindElement(By.Id("login"));
            emailInput.SendKeys("zuhdi.krasniqi@gmail.com");
            IWebElement passlInput = Driver.driver.FindElement(By.Id("password"));
            passlInput.SendKeys(Config.password);
            Driver.driver.FindElement(By.ClassName("form-sub")).Click();

            System.Threading.Thread.Sleep(5000);

            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("wrap-inner"));
            resultsContainer.FindElement(By.ClassName("shot-thumbnail-container"));
            resultsContainer.FindElement(By.Id("shots-like-button")).Click();

            IWebElement jobMenu = Driver.driver.FindElement(By.XPath("//*[@id='home']/div[1]/div[1]/ul/li[3]/a/img"));
            Actions hover = new Actions(Driver.driver);
            hover.MoveToElement(jobMenu).Perform();
            Driver.driver.FindElement(By.XPath("//*[@id='home']/div[1]/div[1]/ul/li[3]/ul/li[5]/a")).Click();
            IWebElement count = Driver.driver.FindElement(By.XPath("//*[@id='wrap']/div[2]/div/div/nav/ul/li[4]/a/span[2]"));
            Assert.IsTrue(count.Text == "1");
        }

        [Test]
        public void TestSave()
        {
            Driver.driver.FindElement(By.ClassName("js-site-nav-sign-in")).Click();

            IWebElement emailInput = Driver.driver.FindElement(By.Id("login"));
            emailInput.SendKeys("zuhdi.krasniqi@gmail.com");
            IWebElement passlInput = Driver.driver.FindElement(By.Id("password"));
            passlInput.SendKeys(Config.password);
            Driver.driver.FindElement(By.ClassName("form-sub")).Click();



            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("wrap-inner"));
            resultsContainer.FindElement(By.ClassName("shot-thumbnail-link"));
            Actions hover = new Actions(Driver.driver);
            hover.MoveToElement(resultsContainer).Perform();
            resultsContainer.FindElement(By.ClassName("shot-action")).Click();
            IWebElement name = Driver.driver.FindElement(By.ClassName("name"));
            name.SendKeys("Testimi");
            Driver.driver.FindElement(By.XPath("//*[@id='new_bucket']/input[3]")).Click();
            System.Threading.Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath("//*[@id='bucket_form']/button")).Click();

           
            Driver.driver.FindElement(By.ClassName("js-site-nav-user-menu")).Click();         
            IWebElement liContainer = Driver.driver.FindElement(By.ClassName("collections"));
              var count = liContainer.FindElement(By.ClassName("count"));
            Assert.IsTrue(count.Text == "1");
        }
    }
}
