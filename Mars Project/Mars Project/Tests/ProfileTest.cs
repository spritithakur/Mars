


using Mars_Project.Pages;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Mars_Project.Tests
{
    [TestFixture]

    public class ProfileTest : CommonDriver

    { 
        [Test, Order(1), Description("Check if seller is able to add profile name")]
        public void addProfileName()

        {
            
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddProfileName(driver);

        }
        [Test, Order(2), Description("Check if seller is able to add availability")]
        public void addAvailability()
        {
            
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddAvailability(driver);

        }


        [Test, Order(3), Description("Check if seller is able to add Description")]
        public void addDescription()
        {
           
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddDescription(driver);
        }
        [Test, Order(4), Description("Check if seller is able to add Language")]
        public void addLanguage()
        {
           
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.AddLanguages(driver);
        }

        [Test, Order(5), Description("Check if seller is able to edit the Language")]

        public void editLanguages()
        {
            
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditLanguages(driver);

        }

        [Test, Order(6), Description("Check if seller is able to delete the language")]

        public void deleteLanguage()
        {
            
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteLanguage(driver);
        }
        }
    }


      

    

   






















