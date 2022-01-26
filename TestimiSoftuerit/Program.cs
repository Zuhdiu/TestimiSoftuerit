using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace TestimiSoftuerit
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var options = new OpenQA.Selenium.Chrome.ChromeOptions();
            options.BinaryLocation = @"C:\Program Files\BraveSoftware\Brave-Browser\Application\brave.exe";

            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(options);
            //Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://telegrafi.com/video/");
        }
    }
}
