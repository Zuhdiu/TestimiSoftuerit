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
    class TS15TestimiFiltrim
    {

        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.sofascore.com/");
        }

        [Test]
        public void TestDate()
        {

            Driver.driver.FindElement(By.XPath("//*[@id='__next']/main/div/div[2]/div/div[1]/div/div[1]/div[2]/div/div/div/div[2]/button[22]")).Click();
            

            IWebElement contanier = Driver.driver.FindElement(By.XPath("//*[@id='__next']/main/div/div[2]/div/div[3]"));
            IReadOnlyCollection<IWebElement> productTitles = contanier.FindElements(By.ClassName("EventCellstyles__Status-sc-4ti8ha-2"));

            foreach (IWebElement title in productTitles)
            {
                var koha = title.FindElement(By.ClassName("Content-sc-1morvta-0"));               

                Assert.IsTrue(koha.Text.Contains("17/01/22"));
            }
        }
        [Test]
        public void TestLive()
        {

            Driver.driver.FindElement(By.XPath("//*[@id='__next']/main/div/div[2]/div/div[3]/div[1]/div[1]/div/div/div/label[2]/span/div")).Click();


            IWebElement contanier = Driver.driver.FindElement(By.ClassName("styles__LiveListContent-sc-17nbpjd-5"));
            IReadOnlyCollection<IWebElement> productTitles = contanier.FindElements(By.ClassName("EventCellstyles__EventCell-sc-4ti8ha-0"));

            foreach (IWebElement title in productTitles)
            {
                var koha = title.FindElement(By.ClassName("EventCellstyles__StatusInfo-sc-4ti8ha-3"));             

                Assert.IsFalse(koha.Text.Equals("FT"));
            }
        }
    }
}
