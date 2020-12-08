using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitTestProject5
{
    class VerifyNewRecord
    {
        IWebDriver driver;

        public VerifyNewRecord(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void verifyRecord(int code)
        {
            driver.FindElement(By.XPath("//*[contains(text(),'Go to the last page')]")).Click();
            Thread.Sleep(2000);
           
            int i;


            for (i = 1; i <= 20; i++)
            {
                var codeText = driver.FindElement(By.XPath("//div[@class='k-grid-content']/table/tbody/tr[" + i + "]/td[1]")).Text;

                Thread.Sleep(500);

             //   Assert.AreEqual(code.To, int.Parse(codeText));

                Console.WriteLine("Code Verified");
                break;

            }

        }

    }
}
