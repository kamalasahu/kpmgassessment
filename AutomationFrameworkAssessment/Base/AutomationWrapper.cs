using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace KPMG.OrangeHRMAutomationFramework.Base
{
    public class AutomationWrapper
    {
        public IWebDriver driver;

        [SetUp]

        public void BeforeMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        }
        [TearDown]
        public void AfterMethod()
        {
            driver.Dispose();
        }
    }
}

