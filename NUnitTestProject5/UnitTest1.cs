using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject5
{
    public class Tests
    {
         
        IWebDriver d1;

        [SetUp]
        public void Setup()
        {
            d1 = new ChromeDriver();
        }

        [Test]


        public void VerifyLoginFUnctionality()
        {

            d1.Navigate().GoToUrl("http://horse.industryconnect.io");
        }


        [TearDown]
        

        public void CloseDriver()

        { 
            d1.Close();
            d1.Dispose();   
        }
       

    }
}