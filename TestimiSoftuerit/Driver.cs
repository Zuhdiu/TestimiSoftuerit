using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit
{
  public  class Driver
    {
        public static IWebDriver driver { get; set; }

        public static void WaitForElementUpTo(double seconds = 20)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
    }
}
