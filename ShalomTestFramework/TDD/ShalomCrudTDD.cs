using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShalomTestFramework.ShalomTests;


namespace ShalomTestFramework.TDD
{
    [TestClass]
    public class ShalomCrudTDD:ShalomTestLogic
    {
        [TestInitialize]
        public void TestSetup()
        {
            GlobalFunction.SetupEnvironment();
            SelectBrowser("Chrome");
            GoToShalom();
        }
        
        [TestMethod]
        [Priority(0)]
        public void ShalomReadTDD()
        {
            ShalomHome();
            ReadShalom();
        }

        [TestMethod]
        [Priority(1)]
        public void ShalomCreateTDD()
        {
            ShalomHome();
            GoToLink("Create New");
        }

        [TestMethod]
        [Priority(2)]
        public void ShalomUpdateTDD()
        {
        }

        [TestMethod]
        [Priority(3)]
        public void ShalomDeleteTDD()
        {
        }

        [TestMethod]
        [Priority(4)]
        public void ShalomNavigate()
        {
            //ShalomHome();
            //GoToLink("Display");
            //ShalomDisplayPage();
            //SearchShalom("Pray the Word");
        }

        [TestCleanup]
        public void UnloadDriver()
        {
        }
    }
}
