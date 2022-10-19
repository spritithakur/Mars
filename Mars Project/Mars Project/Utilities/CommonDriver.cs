using Mars_Project.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        LoginPage loginPageObj = new LoginPage();

        [OneTimeSetUp]
        public void LoginSteps()
        {
            // open chrome browser
            driver = new ChromeDriver();

            // Login page object initialization and definition
         
            loginPageObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void closeTestRun()
        {
            driver.Quit();
        }

    }
}
