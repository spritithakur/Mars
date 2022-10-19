using Mars_Project.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{

    public class ProfilePage

    {

        //For Profiele Name
        public void AddProfileName(IWebDriver driver)
        {

            
            IWebElement dropdownButton = driver.FindElement(By.XPath("(//i[@class='dropdown icon'])[2]"));
            dropdownButton.Click();

            IWebElement FirstNameTextBox = driver.FindElement(By.XPath("//input[@name='firstName' and @type='text']"));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            FirstNameTextBox.Clear();
            FirstNameTextBox.SendKeys("Spriti");

            IWebElement LastNameTextBox = driver.FindElement(By.XPath("//input[@name='lastName' and @type='text']"));
            LastNameTextBox.Clear();
            LastNameTextBox.SendKeys("Thakur");

           

            IWebElement SaveButton = driver.FindElement(By.XPath("//button[@class='ui teal button']"));
            SaveButton.Click();

            Thread.Sleep(3000);


        }
        public string GetProfileName(IWebDriver driver)
        {
            IWebElement newProfileName = driver.FindElement(By.XPath("//div[@class='ui fluid accordion']"));
            return newProfileName.Text;
           
        }

        


        //For Availability
        public void AddAvailability(IWebDriver driver)
        {

            Thread.Sleep(5000);
            IWebElement editAvailabilityButton = driver.FindElement(By.XPath("//i[@class='right floated outline small write icon']"));
            editAvailabilityButton.Click();
            
            
            IWebElement availabilityDropDownButton = driver.FindElement(By.XPath("//select[@class='ui right labeled dropdown']"));
            availabilityDropDownButton.Click();


          
            IWebElement FullTimeText = driver.FindElement(By.XPath("//option[@value='1']"));
            FullTimeText.Click();


            IWebElement availabilityHasBeenSavedSuccessfullyAlert = driver.FindElement(By.XPath("/html/body/div[1]/div"));
           
            
        }
        public string GetAvailability(IWebDriver driver)
        {
            
            IWebElement newAvailability = driver.FindElement(By.XPath("(//div[@class='right floated content'])[2]"));
            return newAvailability.Text;
           
        }


        //For Description
        public void AddDescription(IWebDriver driver)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IWebElement writeIconDescription = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            writeIconDescription.Click();

            
            IWebElement textArea = driver.FindElement(By.XPath("//textarea[@name='value']"));
            Thread.Sleep(3000);
            textArea.Clear();
            
            textArea.SendKeys("Hello");

            
            IWebElement SaveButton1 = driver.FindElement(By.XPath("//button[@type='button']"));
            SaveButton1.Click();


            IWebElement descriptionHasBeenSavedSuccessfullyAlert = driver.FindElement(By.XPath("/html/body/div[1]/div"));
           


        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement newDescription = driver.FindElement(By.XPath("//span[@style='padding-top: 1em;']"));
            return newDescription.Text;
          
        }




        //For Languages
        public void AddLanguages(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement languagesTextArea = driver.FindElement(By.XPath("//a[@data-tab='first']"));
            languagesTextArea.Click();
          
            IWebElement addNew = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNew.Click();

            
            IWebElement AddLanguageTextArea = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            AddLanguageTextArea.SendKeys("English");


            IWebElement chooseLanguageLevelDropDown = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            chooseLanguageLevelDropDown.Click();

            
            IWebElement fluentOption = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            fluentOption.Click();


            IWebElement clickAddButton = driver.FindElement(By.XPath("//input[@value='Add']"));
            clickAddButton.Click();


            IWebElement englishHasBeenAddedToYourLanguagesAlert = driver.FindElement(By.XPath("/html/body/div[1]/div"));
         

        }
        public string GetLanguage(IWebDriver driver)

        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//td[1]"));
            return newLanguage.Text;
        }

        public string GetLevel(IWebDriver driver)
        {
            IWebElement newLevel = driver.FindElement(By.XPath("//td[2]"));
            return newLevel.Text;
        }



        //Edit the recent added language
        public void EditLanguages(IWebDriver driver)
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement editButton = driver.FindElement(By.XPath("(//i[@class='outline write icon'])[2]"));
            editButton.Click();

            
            IWebElement languageTextArea = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
            languageTextArea.Clear();
            languageTextArea.SendKeys("French");

            IWebElement levelDropDownButton = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
            levelDropDownButton.Click();

           
            IWebElement basicOption = driver.FindElement(By.XPath("//option[@value='Basic']"));
            basicOption.Click();
          
            
            IWebElement updateButton = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateButton.Click();

           

            IWebElement frenchHasBeenAddedToYourLanguagesAlert = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            Thread.Sleep(3000);

        }


        public string GetUpdatedLanguage(IWebDriver driver)

        {
            IWebElement updatedLanguage = driver.FindElement(By.XPath("//td[1]"));
            return updatedLanguage.Text;

        }

        public string GetUpdatedLevel(IWebDriver driver)

        {
            IWebElement updatedLevel = driver.FindElement(By.XPath("//td[2]"));
            return updatedLevel.Text;
           

        }

        //Delete the recent edited language
        public void DeleteLanguage(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement deleteButton = driver.FindElement(By.XPath("(//i[@class='remove icon'])[1]"));
            deleteButton.Click();

            IWebElement frenchHasBeenDeletedFromYourLanguagesAlert = driver.FindElement(By.XPath("/html/body/div[1]/div"));
          

        }

        public string GetDeleteLanguage(IWebDriver driver)
        {
          
            return null;
           
           
        }
      


    }









    }
    

