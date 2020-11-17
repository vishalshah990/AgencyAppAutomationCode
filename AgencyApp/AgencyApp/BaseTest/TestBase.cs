using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyApp.TestBase
{
    public class BaseTest
    {
        public static IWebDriver _driver;

        public void LaunchBrowser()
        {
            string s1 = ConfigurationManager.AppSettings["url"];

            // ChromeOptions option = new ChromeOptions();
            //option.AddArgument("--headless");

            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(s1);
        }

        public void CloseBrowser()
        {
            _driver.Quit();
        }
    }
}
