using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AgencyApp.Helper
{
    public class Verification
    {
        public static Boolean verifyElementPresent(IWebElement element)
        {
            Boolean Dispalyed = false;
            try
            {
                Dispalyed = element.Displayed;
                Console.WriteLine(element.Text + "is displayed");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Element not found" + ex);

            }
            return Dispalyed;

        }

        public static Boolean VerifyElementNotPresent(IWebElement element)
        {
            Boolean Displayed = false;
            try
            {
                Displayed = element.Displayed;
                Console.WriteLine(element.Text + "is displayed");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Element not found" + ex);
                Displayed = true;
            }

            return Displayed;
        }
    }
}
