using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject5
{
    public class MainPage
    {
        IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void creatRecord(int random)
        {
            //click on Administrator dropdown
            driver.FindElement(By.XPath("//*[contains(text(),'Administration')]")).Click();
            
            //click on Time & Materials
            driver.FindElement(By.XPath("//*[contains(text(),'Time & Materials')]")).Click();
            
            //click on Create New Button
            driver.FindElement(By.XPath("//*[contains(text(),'Create New')]")).Click();
            
            //Click on material dropdown
            driver.FindElement(By.XPath("//span[text()='Material']")).Click();
            //Thread.Sleep(2000);
            //Select material 
            // Create new button 
            driver.FindElement(By.Id("TypeCode_option_selected")).Click();

            //Enter code value
            driver.FindElement(By.Id("Code")).SendKeys(random.ToString());
            //Enter description
            driver.FindElement(By.Id("Description")).SendKeys("order new unit");
            //save the new created material details
            driver.FindElement(By.Id("SaveButton")).Click();
        }
    }
}
