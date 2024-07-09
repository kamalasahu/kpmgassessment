using KPMG.OrangeHRMAutomationFramework.Base;
using KPMG.OrangeHRMAutomationFramework.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.OrangeHRMAutomationFramework.Test
{
    public class LoginTest : AutomationWrapper
    {
        [Test]

        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("(//button[@type='submit'])")).Click();
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);
            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));
        }
        [Test]
        public void InValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("John");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("(//button[@type='submit'])")).Click();          
            string actualError = driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;
            Console.WriteLine(actualError);
            Assert.That(actualError, Is.EqualTo("Invalid credentials"));
        }

        [Test]
        [TestCaseSource(typeof(DataSource), nameof(DataSource.InValidLoginData))]
        public void InValidLoginTest2(string username, string password, string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("(//button[@type='submit'])")).Click();
            string actualError = driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;
            Console.WriteLine(actualError);
            Assert.That(actualError, Is.EqualTo(expectedError));
        }
    }
}
