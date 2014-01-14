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
    //To store referenced UI Objects
    public class ShalomOR
    {

        public string ShalomIndexTitle = "Study Note - Shalom";
        public string ShalomDisplayTitle = "Dynamic Search by Title - Shalom";
        public string ShalomConcordanceTitle = "Concordance - Shalom";
        public string ShalomWordSearchTitle = "Any Word Search - Shalom";
        public string ShalomRemoveTitle = "RemoveRecord - Shalom"; //Search by Title
        public string ShalomAboutTitle = "About - Shalom";
        public string ShalomReadTitle = "Read - Shalom";
        public string baseUrl = "http://selah.azurewebsites.net/";

        public string SearchInput = "search";
        public string SearchClick = "/html/body/div/section/form/input[2]"; 

        //Link Strings
        public string Shalom = "Shalom";
        public string Home = "Home";
        public string Display = "Display";
        public string Concordance = "Concordance";
        public string WordSearch = "Word Search";
        public string Remove = "Remove";
        public string About = "About";

        public string Create = "Create New";

        public string RowHeader = "/html/body/div/section/div/table/tbody/tr/th";
        public string RowOneAll = "/html/body/div/section/div/table/tbody/tr[2]/td";

        public string RowOneTitle = "/html/body/div/section/div/table/tbody/tr[2]/td[1]";
        public string RowOneRead = "/html/body/div/section/table/tbody/tr[2]/td[5]/a";
        //"/html/body/div/section/div/table/tbody/tr[2]/td[5]/a";

#region Training Encapsulation
// Encapsulation and abstraction is the advanced mechanism in C# that lets your program to hide unwanted code 
//within a capsule and shows only essential features of an object. Encapsulation is used to hide its members from 
//outside class or interface, whereas abstraction is used to show only essential features.
//Encapsulation is the process of hiding irrelevant data from the user
        protected string SearchInputOM = "search";
        private string prString = "My Private String";

        public string PRString
        {
            get { return prString = "My Private String";}
            set { prString = "My Private String"; }
        }
        //private virtual method is illegal in C#
        //private virtual void TestPrivateVirtualMethod(string TestPrivateVM) { } //virtual or abstract members cannot be private

        private void TestPrivateMethod(string TestPR) { }
        public void TestPublicMethod(string TestPU) { }
        protected virtual void TestProtectedVirtualMethod() { } 
        protected virtual void TestProtectedVirtualMethod(string TestPRV)
        { Console.WriteLine("Original TestProtectedVirtualMethod"); }
        public virtual void TestPublicVirtualMethod() { }      
        public virtual void TestPublicVirtualMethod(string TestPVU)
        { Console.WriteLine("Original TestPublicVirtualMethod"); }

#endregion
    }
}


