using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShalomTestFramework.ShalomTests
{
    interface IShalomTestLogic
    {
        void SelectBrowser(string Browser);
        void GoToShalom();
        void SearchShalom(string SearchString);
        void ReadShalom();
        void CreateShalom();
        void UpdateShalom();
        void DeleteShalom();
        void ExitShalom();

        void ShalomSelectAll();
        void ShalomSelectOne();
        void ShalomByTitle();
        void ShalomByBible();
        void ShalomByStudyType();
        void ShalomByAuthor();
        void ShalomByByPlatform();
        void ShalomByTag();
        void ShalomByNotes();

        void ShalomVerify();
        void ShalomHome();
        void ShalomDisplayPage();
        void ShalomConcordancePage();
        void ShalomWordSearchPage();
        void ShalomRemovePage();
        void ShalomAboutPage();

        void GoToLink(string LinkName);
        void GoToDisplay();
        void GoToConcordance();
        void GoToWordSearch();
        void GoToRemove();
        void GoToAbout();


#region Training

        //int InterfaceInteger; //interface cannot contain fields
        //string InterfaceString; //interface cannot contain fields
       // public void Print() //modifier is not valid for this item

        void ImplementMember();
        //{
        //    Console.WriteLine("Print"); //interface members cannot have a definition
        //}
#endregion
    }
}