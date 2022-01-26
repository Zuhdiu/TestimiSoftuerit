
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Culi
{
    class TS7LAN
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.hltv.org/");
        }

        //TS6
        [Test]
        public void TestTimeFilter()
        {
            Driver.driver.FindElement(By.ClassName("navstats")).Click();

            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();

            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.ClassName("stats-sub-navigation-simple-filter-time")).Click();

            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.CssSelector("body > div.bgPadding > div > div.colCon > div.contentCol > div.stats-section > div.stats-top-menu > div > div > div:nth-child(2) > form > select > option:nth-child(8)")).Click();

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.Equals("https://www.hltv.org/stats?startDate=2020-01-01&endDate=2020-12-31"));
        }
        [Test]
        public void TestMajors()
        {
            Driver.driver.FindElement(By.ClassName("navstats")).Click();

            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();

            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.ClassName("stats-sub-navigation-simple-filter-matchtype")).Click();
           
            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.CssSelector("body > div.bgPadding > div > div.colCon > div.contentCol > div.stats-section > div.stats-top-menu > div > div > div:nth-child(1) > form > select > option:nth-child(5)")).Click();

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.Equals("https://www.hltv.org/stats?matchType=Majors"));
        }

        //TS7 
        [Test]
        public void TestLan()
        {
            Driver.driver.FindElement(By.ClassName("navmatches")).Click();
          
            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.XPath("//*[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']")).Click();

            System.Threading.Thread.Sleep(3000);

            Driver.driver.FindElement(By.XPath("/html/body/div[3]/div/div[2]/div[1]/div[2]/div[4]/div/div[2]/div/div[1]/div/a[3]/div")).Click();

            string pageTitle = Driver.driver.Url;
            Assert.IsTrue(pageTitle.Equals("https://www.hltv.org/matches?predefinedFilter=lan_only"));
        }
    }
}
