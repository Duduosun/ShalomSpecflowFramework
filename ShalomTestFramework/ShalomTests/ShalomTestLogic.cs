using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using ShalomTestFramework.POM;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShalomTestFramework.ShalomTests
{
     public class ShalomTestLogic : IShalomTestLogic
    {

         public ShalomOM shalomOM = new ShalomOM();

#region Utility
         public void SelectBrowser(string Browser)
         {
             if (Browser == "Firefox")
                 shalomOM.webDriver = new FirefoxDriver();
             else if (Browser == "Chrome")
                 shalomOM.webDriver = new ChromeDriver();
             else if (Browser == "IE")
                 shalomOM.webDriver = new InternetExplorerDriver();
         }

        public void GoToShalom()
        {
            shalomOM.webDriver.Navigate().GoToUrl(shalomOM.baseUrl);
            shalomOM.webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomIndexTitle));
            ShalomVerify();
        }
#endregion

#region CRUD Logic
        public void SearchShalom(string SearchString)
        {
            shalomOM.SearchTextBox.SendKeys(SearchString);
            shalomOM.webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //Assert.IsTrue(shalomOM.SearchRowOneTitle.Text.Equals(SearchString));
            //Assert.AreEqual(shalomOM.SearchRowOneTitle.Text, SearchString);
        }

        public void ReadShalom()
        {
            if (shalomOM.RowOneReadLink.Enabled)
            {
                shalomOM.RowOneReadLink.Click();
            }
        }

        public void CreateShalom()
        {
            throw new NotImplementedException();
        }

        public void UpdateShalom()
        {
            throw new NotImplementedException();
        }

        public void DeleteShalom()
        {
            throw new NotImplementedException();
        }

        public void ExitShalom()
        {
            throw new NotImplementedException();
        }
#endregion

#region View Logic
        public void ShalomSelectAll()
        {
            throw new NotImplementedException();
        }

        public void ShalomSelectOne()
        {
            throw new NotImplementedException();
        }

        public void ShalomByTitle()
        {
            throw new NotImplementedException();
        }

        public void ShalomByBible()
        {
            throw new NotImplementedException();
        }

        public void ShalomByStudyType()
        {
            throw new NotImplementedException();
        }

        public void ShalomByAuthor()
        {
            throw new NotImplementedException();
        }

        public void ShalomByByPlatform()
        {
            throw new NotImplementedException();
        }

        public void ShalomByTag()
        {
            throw new NotImplementedException();
        }

        public void ShalomByNotes()
        {
            throw new NotImplementedException();
        }

#endregion

#region Page Navigation Verification
        public void ShalomVerify()
        {
            Assert.AreEqual(shalomOM.ShalomLink.Text, GlobalFunction.Shalom);
            Assert.AreEqual(shalomOM.ShalomHomeLink.Text, GlobalFunction.Home);
            Assert.AreEqual(shalomOM.ShalomDisplayLink.Text, GlobalFunction.Display);
            Assert.AreEqual(shalomOM.ShalomConcordanceLink.Text, GlobalFunction.Concordance);
            Assert.AreEqual(shalomOM.ShalomWordSearchLink.Text, GlobalFunction.WordSearch);
            Assert.AreEqual(shalomOM.ShalomRemoveLink.Text, GlobalFunction.Remove);
            Assert.AreEqual(shalomOM.ShalomAboutLink.Text, GlobalFunction.About);
        }

        public void ShalomHome()
        {
            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomIndexTitle));
            ShalomVerify();
            Assert.IsTrue(shalomOM.CreateButton.Enabled);
        }

        public void ShalomDisplayPage()
        {
            ShalomVerify();
            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomDisplayTitle));
            Assert.IsTrue(shalomOM.SearchButton.Enabled);
            Assert.IsTrue(shalomOM.SearchTextBox.Enabled);
            //Assert.AreEqual(shalomOM.SearchButton.Text, shalomOM.SearchClick);          
        }

        public void ShalomConcordancePage()
        {
            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomConcordanceTitle));
            ShalomVerify();
        }

        public void ShalomWordSearchPage()
        {
            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomWordSearchTitle));
            ShalomVerify();
        }

        public void ShalomRemovePage()
        {
            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomRemoveTitle));
            ShalomVerify();
        }

        public void ShalomAboutPage()
        {
            Assert.IsTrue(shalomOM.webDriver.Title.Equals(shalomOM.ShalomAboutTitle));
            ShalomVerify();
        }
#endregion

#region GoTo

        public void GoToLink(string LinkName)
        {
            switch (LinkName)
            {
                case "Shalom":
                    if (shalomOM.ShalomLink.Enabled)
                    {
                        shalomOM.ShalomLink.Click();
                    } 
                    break;
                case "Home":
                    if (shalomOM.ShalomHomeLink.Enabled)
                    {
                        shalomOM.ShalomHomeLink.Click();
                    } 
                    break;
                case "Display":
                    if (shalomOM.ShalomDisplayLink.Enabled)
                    {
                        shalomOM.ShalomDisplayLink.Click();
                    } 
                    break;
                case "Concordance":
                    if (shalomOM.ShalomConcordanceLink.Enabled)
                    {
                        shalomOM.ShalomConcordanceLink.Click();
                    } 
                    break;
                case "Word Search":
                    if (shalomOM.ShalomWordSearchLink.Enabled)
                    {
                        shalomOM.ShalomWordSearchLink.Click();
                    } 
                    break;
                case "Remove":
                    if (shalomOM.ShalomRemoveLink.Enabled)
                    {
                        shalomOM.ShalomRemoveLink.Click();
                    } 
                    break;
                case "About":
                    if (shalomOM.ShalomAboutLink.Enabled)
                    {
                        shalomOM.ShalomAboutLink.Click();
                    } 
                    break;
                case "Create New":
                    if (shalomOM.CreateButton.Enabled)
                    {
                        shalomOM.CreateButton.Click();
                    }
                    break; 
                default:
                    Process.Start("notepad.exe");
                    break;
            }
        }

        public void GoToDisplay()
        {
            if (shalomOM.ShalomDisplayLink.Enabled)
            {
                shalomOM.ShalomDisplayLink.Click();
            }           
        }

        public void GoToConcordance()
        {
            throw new NotImplementedException();
        }

        public void GoToWordSearch()
        {
            throw new NotImplementedException();
        }

        public void GoToRemove()
        {
            throw new NotImplementedException();
        }

        public void GoToAbout()
        {
            throw new NotImplementedException();
        }
#endregion


#region Training
        public void ImplementMember()
        {
            throw new NotImplementedException();
        }


#endregion
    }
}
