using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Threading;

namespace NUnitTestProject5
{
    public class Tests
    {
         
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Implicit wait : it made the driver wait for some specfied amount of time 
            // till element to be interacted was not available.

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [Test]
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
           var x=  driver.FindElement(By.LinkText("Hello hari!")).Text;
           if(x == "Hello hari!")
            {
                Console.WriteLine("Login Successfull");
            }
            else
            {
                Console.WriteLine("Login Unsuccessfull");
            }
            //Click on Hello hari! dropdown
            driver.FindElement(By.LinkText("Hello hari!")).Click();
            //Thread.Sleep(2000);            
            //click on Administrator dropdown
            driver.FindElement(By.XPath("//*[contains(text(),'Administration')]")).Click();
            //Thread.Sleep(2000);
            //click on Time & Materials
            driver.FindElement(By.XPath("//*[contains(text(),'Time & Materials')]")).Click();
            //Thread.Sleep(2000);
            //click on Create New Button
            driver.FindElement(By.XPath("//*[contains(text(),'Create New')]")).Click();
            //Thread.Sleep(2000);
            //Click on material dropdown
            driver.FindElement(By.XPath("//span[text()='Material']")).Click();
            //Thread.Sleep(2000);
            //Select material

            // Transition to Create Flow 

            // Create new button 
            driver.FindElement(By.Id("TypeCode_option_selected")).Click();
            //Thread.Sleep(2000);
            //Enter code value
            driver.FindElement(By.Id("Code")).SendKeys("7878");
            //Enter description
            driver.FindElement(By.Id("Description")).SendKeys("order new unit");
            //Thread.Sleep(2000);
            //save the new created material details
            driver.FindElement(By.Id("SaveButton")).Click();
            //Thread.Sleep(2000);
        }
        [TearDown]
       
        public void CloseDriver()

        { 
            driver.Close();
            driver.Dispose();   
        }
       

    }
}