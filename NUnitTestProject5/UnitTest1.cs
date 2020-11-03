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
            Thread.Sleep(5000);

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
            Thread.Sleep(5000);


            // driver.FindElement(By.CssSelector("li [class= dropdown]a [data-toggle= dropdown]"));
            
            //click on Administrator dropdown
            driver.FindElement(By.XPath("//*[contains(text(),'Administration')]")).Click();
            Thread.Sleep(5000);
            





        }
        [TearDown]
        

        public void CloseDriver()

        { 
            driver.Close();
            driver.Dispose();   
        }
       

    }
}