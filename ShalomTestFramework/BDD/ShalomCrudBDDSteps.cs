using ShalomTestFramework.ShalomTests;
using System;
using TechTalk.SpecFlow;


namespace ShalomTestFramework
{
    [Binding]
    public class ShalomCrudBDDSteps:ShalomTestLogic
    {
        [Given(@"Shalom Web App")]
        public void GivenShalomWebApp()
        {
            GlobalFunction.SetupEnvironment();
            SelectBrowser("Chrome");
            GoToShalom();
        }
        
        [When(@"I search a Study")]
        public void WhenISearchAStudy()
        {
            //Display Concordance Word Search

        }
        
        [When(@"I create a Study")]
        public void WhenICreateAStudy()
        {
            ShalomHome();
            GoToLink("Create New");
        }
        
        [When(@"I update a Study")]
        public void WhenIUpdateAStudy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I delete a Study")]
        public void WhenIDeleteAStudy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can access the Study")]
        public void ThenICanAccessTheStudy()
        {
            ReadShalom();
        }
        
        [Then(@"I can read the Study")]
        public void ThenICanReadTheStudy()
        {
            GoToLink("Home");
            ReadShalom();
        }
        
        [Then(@"I can search the Study")]
        public void ThenICanSearchTheStudy()
        {
            GoToLink("Display");
            ShalomDisplayPage();
            SearchShalom("Pray the Word");
        }
        
        [Then(@"I cannot access the Study")]
        public void ThenICannotAccessTheStudy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I cannot read the Study")]
        public void ThenICannotReadTheStudy()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
