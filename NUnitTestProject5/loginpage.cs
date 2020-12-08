using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject5
{
    class loginpage
    {
        IWebDriver driver;

        public loginpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void VerifyLoginFUnctionality()
        {
            //Open horse industry connect website
            driver.Navigate().GoToUrl("http://horse.industryconnect.io");
            //Enter valid username
            driver.FindElement(By.Id("UserName")).SendKeys("Hari");
            //Enter valid password
            driver.FindElement(By.Id("Password")).SendKeys("123123");
            //Click on Submit buttton
            driver.FindElement(By.CssSelector("input[type= submit]")).Click();
            //Thread.Sleep(5000);
            //Verifying Username on home page
            var x = driver.FindElement(By.LinkText("Hello hari!")).Text;
            if (x == "Hello hari!")
            {
                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("Login Unsuccessful");
            }
        }
    }
}
