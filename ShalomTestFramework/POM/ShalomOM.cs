using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomTestFramework.POM
{
    //To store properties for identifying UI Objects
    public class ShalomOM : ShalomOR
    {
        public IWebDriver webDriver;
        public ShalomOR shalomOR = new ShalomOR();

        public IWebElement SearchTextBox { get { return webDriver.FindElement(By.Id(shalomOR.SearchInput)); } }    
        public IWebElement ShalomLink { get { return webDriver.FindElement(By.LinkText(shalomOR.Shalom)); } }
        public IWebElement ShalomHomeLink { get { return webDriver.FindElement(By.LinkText(shalomOR.Home)); } }
        public IWebElement ShalomDisplayLink { get { return webDriver.FindElement(By.LinkText(shalomOR.Display)); } }
        public IWebElement ShalomConcordanceLink { get { return webDriver.FindElement(By.LinkText(shalomOR.Concordance)); } }
        public IWebElement ShalomWordSearchLink { get { return webDriver.FindElement(By.LinkText(shalomOR.WordSearch)); } }
        public IWebElement ShalomRemoveLink { get { return webDriver.FindElement(By.LinkText(shalomOR.Remove)); } }
        public IWebElement ShalomAboutLink { get { return webDriver.FindElement(By.LinkText(shalomOR.About)); } }

        public IWebElement CreateButton { get { return webDriver.FindElement(By.LinkText(shalomOR.Create)); } }

        public IWebElement SearchButton { get { return webDriver.FindElement(By.XPath(shalomOR.SearchClick)); } }
        public IWebElement SearchRowHeader { get { return webDriver.FindElement(By.XPath(shalomOR.RowHeader)); } }
        public IWebElement SearchRowOneAll { get { return webDriver.FindElement(By.XPath(shalomOR.RowOneAll)); } }
        public IWebElement SearchRowOneTitle { get { return webDriver.FindElement(By.XPath(shalomOR.RowOneTitle)); } }
        public IWebElement RowOneReadLink { get { return webDriver.FindElement(By.XPath(shalomOR.RowOneRead)); } }

 #region Training Abstraction
//Encapsulation is used to hide its members from outside class or interface, 
//whereas abstraction is used to show only essential features.
 //Encapsulation is the process of hiding irrelevant data from the user
//Abstraction is just opposite of Encapsulation. Abstraction is mechanism to show only relevant data to the user
        public ShalomOM shalomOM = new ShalomOM();

//Can the private variables from an inherited class be accessed - No

        public IWebElement SearchTextBoxOM { get { return webDriver.FindElement(By.Id(shalomOM.SearchInputOM)); } } //inherited n accessible protected string
        public IWebElement GetprString { get { return webDriver.FindElement(By.Id(shalomOM.PRString)); } }
        public IWebElement GetprStringOR { get { return webDriver.FindElement(By.Id(shalomOR.PRString)); } }

        //public IWebElement GetMyPrivateString { get { return webDriver.FindElement(By.Id(shalomOM.prString)); } } //innaccessible due to protection level - private string
        //public IWebElement GetMyPrivateStringOR { get { return webDriver.FindElement(By.Id(shalomOR.prString)); } } //innaccessible due to protection level - private string
        
        public void TestVirtualFromOR()
        {
            shalomOM.TestPublicMethod("TestPU");
            //Can the private methods from an inherited class be accessed - No
            //shalomOM.TestPrivateMethod("TestPU"); //inaccessible due to protection level
            shalomOM.TestProtectedVirtualMethod("TestPU");
            shalomOM.TestPublicVirtualMethod("TestPVU");
            shalomOM.TestPublicVirtualMethod();
            shalomOM.TestProtectedVirtualMethod();
        }

        public override void TestPublicVirtualMethod() { }
        public override void TestPublicVirtualMethod(string TestPVU)
        {
            Console.WriteLine("Overriden TestPublicVirtualMethod");
        }

        protected override void TestProtectedVirtualMethod() { }
        protected override void TestProtectedVirtualMethod(string TestPRV)
        {
            Console.WriteLine("Overriden TestProtectedVirtualMethod");
        }
 #endregion
    }
}
