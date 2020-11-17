using AgencyApp.TestBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AgencyApp.AppAgenCyPages;
using System.Configuration;

namespace AgencyApp.TestCase
{
    public class LoginPageTest : BaseTest
    {
        LoginPage loginpage;

        [OneTimeSetUp]
        public void OpenApplication()
        {
            LaunchBrowser();
            loginpage = new LoginPage(_driver);

        }

        [Test, Order(1)]
        public void TestValidLogin()
        {
            string s1 = ConfigurationManager.AppSettings["Username"];
            string s2 = ConfigurationManager.AppSettings["Password"];
            loginpage.ValidLogin(s1, s2);
            Console.WriteLine(_driver.Title);
        }

        [Test, Order(2)]
        public void LogOutTest()
        {
            loginpage.LogOutfromApplication();
            CloseBrowser();
        }
    }
}
