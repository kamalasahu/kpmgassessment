using KPMG.OrangeHRMAutomationFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.OrangeHRMAutomationFramework.Test
{
    public class EmployeeTest : AutomationWrapper
    {

        [Test]
        public void TestEmployee()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("(//button[@type='submit'])")).Click();
            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.LinkText("Add Employee")).Click();
            //add new EE details
            driver.FindElement(By.Name("firstName")).SendKeys("John");
            driver.FindElement(By.Name("middleName")).SendKeys("W");
            driver.FindElement(By.Name("lastName")).SendKeys("Wick");
            driver.FindElement(By.XPath("(//img[@alt='profile picture'])[2]")).SendKeys("C:/image.jpg"); // Unable to execute step 10 11
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string employeeName = driver.FindElement(By.XPath("//h6[text()='John Wick']")).Text;
            Console.WriteLine(employeeName);
            Assert.That(employeeName, Is.EqualTo("John Wick"));
            
        }
    }
}
