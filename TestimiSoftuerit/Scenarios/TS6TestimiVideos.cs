using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS6TestimiVideos
    {
        

        [SetUp]
        public void Setup()
        {
            //TestPlayback
            //BrowserActions.InitializeDriver("https://telegrafi.com/video/");

            //TestPip
            BrowserActions.InitializeDriver("https://telegrafi.com/video/njihuni-amecan-robotin-humanoid-qe-beri-te-gjithe-per-vete-ne-las-vegas-gjate-ces/");
        }

        [Test]
        public void TestPlayback()
        {            
            //IWebElement resultsContainer = Driver.driver.FindElement(By.XPath(" / html / body / div[8] / div / div"));
            //resultsContainer.FindElement(By.ClassName("videoIndicator")).Click();
            //Driver.WaitForElementUpTo();
            IWebElement resultsContainer2 = Driver.driver.FindElement(By.ClassName("article-container"));
            var videoSrc = resultsContainer2.FindElement(By.TagName("iframe"));

            Driver.driver.SwitchTo().Frame(videoSrc);
            var testim = Driver.driver.FindElement(By.ClassName("jw-icon-playback"));
            string a = testim.GetAttribute("aria-label");
            Assert.IsTrue(a.Contains("Pause"));
        }


        [Test]
        public void TestPip()
        {
            IWebElement resultsContainer2 = Driver.driver.FindElement(By.ClassName("article-container"));
            var videoSrc = resultsContainer2.FindElement(By.TagName("iframe"));

             Driver.driver.SwitchTo().Frame(videoSrc);
             Driver.driver.FindElement(By.ClassName("jw-icon-pip")).Click();
           
            var testim = Driver.driver.FindElement(By.ClassName("jw-icon-pip"));
            string a = testim.GetAttribute("class");
            Assert.IsTrue(a.Contains("jw-off"));
        }

    }
}

