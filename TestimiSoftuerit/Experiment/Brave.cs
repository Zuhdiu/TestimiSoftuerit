using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Experiment
{
    class Brave
    {     

        //[SetUp]
        //public void Setup()
        //{
        //    BrowserActions.InitializeDriver("https://jobs.telegrafi.com/login");
        //}
        [Test]
        public void TestWallet()
        {
            var options = new OpenQA.Selenium.Chrome.ChromeOptions();
            options.BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";

            //System.Uri uri = new System.Uri("http://localhost:51548/hub");         
            //IWebDriver driver = new RemoteWebDriver(uri, ChromeDriver(options));

            IWebDriver driver= new OpenQA.Selenium.Chrome.ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://telegrafi.com/video/");

        }

        public void LoadChrome()
        {
           
        }
    }

    
}
