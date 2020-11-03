using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

            driver.Navigate().GoToUrl("http://horse.industryconnect.io");

            driver.FindElement(By.Id("UserName")).SendKeys("Hari");

            driver.FindElement(By.Id("Password")).SendKeys("123123");

            driver.FindElement(By.CssSelector("input[type= submit]")).Click();
            Thread.Sleep(5000);

        
            
            driver.FindElement(By.LinkText("Hello hari!")).Click();

            //d1.FindElement(By.CssSelector("li [class= dropdown])a [data-toggle= dropdown]"));

        }


        [TearDown]
        

        public void CloseDriver()

        { 
            driver.Close();
            driver.Dispose();   
        }
       

    }
}