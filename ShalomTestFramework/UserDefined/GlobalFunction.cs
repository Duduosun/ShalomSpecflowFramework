using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomTestFramework
{

//Static classes and class members are used to create data and functions that can be accessed without creating an //instance of the class - static methods and properties can only access static fields and static events
    public static class GlobalFunction
    {
        public static IWebDriver webDriver;

        public static string Shalom = "Shalom";
        public static string Home = "Home";
        public static string Display = "Display";
        public static string Concordance = "Concordance";
        public static string WordSearch = "Word Search";
        public static string Remove = "Remove";
        public static string About = "About";

        public static void SetupEnvironment()
        {
        }
        public static void PopupHandler()
        {
            String parentWindowHandle = webDriver.CurrentWindowHandle; //Save Current Window Handle.
            IWebDriver popup = null;
            var windowIterator = webDriver.WindowHandles;

            foreach (var windowHandle in windowIterator)
            {
                popup = webDriver.SwitchTo().Window(windowHandle);

                if (popup.Title == "Shalom")
                {
                    break;
                }
            }
        }
        public static void SelectBrowser(string Browser)
        {
            IWebDriver webDriver = null;

            if (Browser == "Firefox")
                webDriver = new FirefoxDriver();
            else if (Browser == "Chrome")
                webDriver = new ChromeDriver();
            else if (Browser == "IE")
                webDriver = new InternetExplorerDriver();
        }

        public static void ShalomHome()
        {
        }
        public static void ShalomDisplayPage()
        {
        }
        public static void ShalomConcordancePage()
        {
        }
        public static void ShalomWordPage()
        {
        }
        public static void ShalomSearchPage()
        {
        }
        public static void ShalomRemovePage()
        {
        }
        public static void ShalomAboutPage()
        {
        }
    }
}
