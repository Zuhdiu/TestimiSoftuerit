using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit.Scenarios
{
    class TS8TestimiButonaveSh
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://telegrafi.com/te-kemi-endemi-ne-vend-te-pandemise/");
        }

        [Test]
        public void TestCopyLink()
        {


        }
    }
}
