using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit
{
    class BrowserActions
    {
        public static void InitializeDriver(string url = "", double seconds = 20)
        {
            if (string.IsNullOrEmpty(url)) { url = Config.BaseUrl; }

            Driver.driver = new ChromeDriver();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
            Driver.driver.Navigate().GoToUrl(url);
            Driver.driver.Manage().Window.Maximize();
        }

        public static void MakeScreenshot(string filename)
        {
            string screenshotDirectory = Config.ScreenshotDir;
            Screenshot browserScreenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            browserScreenshot.SaveAsFile(screenshotDirectory + @"\" + filename + ".png", ScreenshotImageFormat.Png);
        }
    }
}
