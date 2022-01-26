using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestimiSoftuerit
{
    public class Config
    {
        public static string BaseUrl = "https://riinvest.net";
        public static string Gjirafa50Url = "https://gjirafa50.com";
        public static string AmazonURL = "https://amazon.com";
        public static string password = "Zuhdi123.";
        public static string ScreenshotDir = @"C:\Users\arian\source\repos\SoftwareTestingWeek6Online\SoftwareTestingWeek6Online\Screenshots\";

        public static class AlertMessages
        {
            public static string InvalidLogin = "Përdoruesi ose Fjalëkalimi është gabim.";
        }
    }
}
