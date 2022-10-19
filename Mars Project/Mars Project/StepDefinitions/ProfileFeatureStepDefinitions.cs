using Mars_Project.Pages;
using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_Project.StepDefinitions
{
    [Binding]
    public class ProfileFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        ProfilePage profilePageObj = new ProfilePage();



        [Given(@"I Logged into LocalHost successfully")]
        public void GivenILoggedIntoLocalHostSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginSteps(driver);
        }

        //FOr Profile Name

        [When(@"I Add First name and Last name in profile page")]
        public void WhenIAddFirstNameAndLastNameInProfilePage()
        {
            profilePageObj.AddProfileName(driver);
        }

        [Then(@"The Profile name should be added successfully")]
        public void ThenTheProfileNameShouldBeAddedSuccessfully()
        {
            string newProfileName = profilePageObj.GetProfileName(driver);
            Assert.That(newProfileName == "Spriti Thakur", "Actual name and expected name do not match");
        }

        //For availability

        [When(@"I Select Full time availability")]
        public void WhenISelectFullTimeAvailability()
        {
            profilePageObj.AddAvailability(driver);
        }

        [Then(@"The Availability should be updated successfully")]
        public void ThenTheAvailabilityShouldBeUpdatedSuccessfully()
        {
            string newAvailability = profilePageObj.GetAvailability(driver);
            Assert.That(newAvailability == "Full Time", "Actual availability and expected availability do not match");
        }

        //For Description

        [When(@"I Added Description on profile page")]
        public void WhenIAddedDescriptionOnProfilePage()
        {
            profilePageObj.AddDescription(driver);
        }

        [Then(@"The Description should be updated successfully")]
        public void ThenTheDescriptionShouldBeUpdatedSuccessfully()
        {
            string newDescription = profilePageObj.GetDescription(driver);
            Assert.That(newDescription == "Hello", "Actual description and expected description do not match");
        }


        //Add Language

        [When(@"Add New language details on profile page")]
        public void WhenAddNewLanguageDetailsOnProfilePage()
        {
            profilePageObj.AddLanguages(driver);
        }



        [Then(@"The Language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = profilePageObj.GetLanguage(driver);
            string newLevel = profilePageObj.GetLevel(driver);

            Assert.That(newLanguage == "English", "Actual Language and expected language do not match");
            Assert.That(newLevel == "Fluent", "Actual level and expected level do not match");

        }

        //Edit language


        [When(@"Edit the existing language details on profile page")]
        public void WhenEditTheExistingLanguageDetailsOnProfilePage()
        {
            profilePageObj.EditLanguages(driver);
        }



        [Then(@"French has been updated to your languages")]
        public void ThenFrenchHasBeenUpdatedToYourLanguages()
        {
            string updatedLanguage = profilePageObj.GetUpdatedLanguage(driver);
            string updatedLevel = profilePageObj.GetUpdatedLevel(driver);


            Assert.That(updatedLanguage == "French", "Actual Language and expected language do not match");
            Assert.That(updatedLevel == "Basic", "Actual Level and expected level do not match");
        }


        //For delete language

        [When(@"Delete the exisitng language record on profile page")]
        public void WhenDeleteTheExisitngLanguageRecordOnProfilePage()
        {
            profilePageObj.DeleteLanguage(driver);
        }


        [Then(@"French has been deleted from your languages")]
        public void ThenFrenchHasBeenDeletedFromYourLanguages()
        {
            string DeleteLanguage = profilePageObj.GetDeleteLanguage(driver);


            Assert.AreEqual(null, DeleteLanguage);
           
           // Assert.AreEqual(null, deleteLevel);
        }
    }
}
