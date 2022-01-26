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
    class TS11TestimiPhoto
    {
        [SetUp]
        public void Setup()
        {

            BrowserActions.InitializeDriver("https://imgur.com/");
        }

        [Test]
        public void TestAddPhoto()
        {
            Driver.driver.FindElement(By.ClassName("newPostLabel")).Click();
            IWebElement photoInput = Driver.driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/div[1]/div[2]/div[2]/input"));           
            string filePath = "https://media.sproutsocial.com/uploads/meme-example.jpg";        
            Thread.Sleep(2000);
            photoInput.SendKeys(filePath);
            Thread.Sleep(2000);
            IReadOnlyCollection<IWebElement> productTitles = Driver.driver.FindElements(By.TagName("img"));
            Assert.IsTrue(productTitles.Count > 0);
        }


        [Test]
        public void TestAddVideo()
        {
            Driver.driver.FindElement(By.ClassName("newPostLabel")).Click();
            IWebElement photoInput = Driver.driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div/div/div[1]/div[2]/div[2]/input"));
            string filePath = "https://media.sproutsocial.com/uploads/meme-example.mp4";
            Thread.Sleep(2000);
            photoInput.SendKeys(filePath);
            Thread.Sleep(2000);
            IReadOnlyCollection<IWebElement> productTitles = Driver.driver.FindElements(By.TagName("frame"));

            Assert.IsTrue(productTitles.Count > 0);
        }
    }
}
