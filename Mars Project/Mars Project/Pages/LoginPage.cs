using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)

        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            IWebElement SignInText = driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a"));
            SignInText.Click();
            Thread.Sleep(3000);


            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.Click();
            usernameTextbox.SendKeys("thakurspriti003@gmail.com");



            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.Click();
            passwordTextbox.SendKeys("1aA,aaaa");

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(3000);



        }
    }
}




    

