using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit
{
    class Config
    {
        public static string BaseUrl = "https://riinvest.net";
        public static string Gjirafa50Url = "https://gjirafa50.com";
        public static string AmazonURL = "https://amazon.com";
        public static string ScreenshotDir = @"C:\Users\arian\source\repos\SoftwareTestingWeek6Online\SoftwareTestingWeek6Online\Screenshots\";
        public static string filteredWord = "airpods";
        public static class Credentials
        {
            public static class Valid
            {
                public static string Username = "M0196";
                public static string Password = "Valid_Password";
            }

            public static class Invalid
            {
                public static string Username = "Test";
                public static string Password = "Invalid_Password";
            }

        }

        public static class AlertMessages
        {
            public static string InvalidLogin = "Përdoruesi ose Fjalëkalimi është gabim.";
        }
    }
}
