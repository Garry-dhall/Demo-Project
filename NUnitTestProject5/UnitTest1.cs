using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;
using System;
using System.Threading;

namespace NUnitTestProject5
{
    public class UnitTest1
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Implicit wait : it made the driver wait for some specfied amount of time 
            // till element to be interacted was not available.

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        [Test]
        public void VerifyRecordCanBeCreatedOnHorsePortal()
        {

            int code = new Random().Next(1089, 1999);

            // verify login functionality
            loginpage Verify = new loginpage(driver);
            Verify.VerifyLoginFUnctionality();

            //create new record
            MainPage create = new MainPage(driver);
            create.creatRecord(code);

            // Verify new record
            VerifyNewRecord Code = new VerifyNewRecord(driver);
            Code.verifyRecord(code);

        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}