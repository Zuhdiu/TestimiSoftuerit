using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS5TestimiWindow
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.neptun-ks.com/");
        }

        [Test]
        public void TestWindowMinimize()
        {
          Driver.driver.Manage().Window.Minimize();
           var dm = Driver.driver.Manage().Window.Size;
            int relativemaxheight = 744; 
            int relativemaxwidth = 1382;
            Assert.IsTrue(dm.Height < relativemaxheight && dm.Width < relativemaxwidth);
        }
        [Test]
        public void TestWindowMaximize()
        {
            Driver.driver.Manage().Window.Maximize();
            var dm = Driver.driver.Manage().Window.Size;
            int relativemaxheight = 744;
            int relativemaxwidth = 1382;
            Assert.IsTrue(dm.Height == relativemaxheight && dm.Width == relativemaxwidth);
        }
    }
}
