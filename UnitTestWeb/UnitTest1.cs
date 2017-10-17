using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestWeb
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;
        [AssemblyInitialize]
        public static void SetUpWeb(TestContext context)
        {
            driver = new ChromeDriver(@"C:\Users\Admin\Documents\Visual Studio 2017\Projects\UnitTestWeb\UnitTestWeb");
            driver.Manage().Window.Maximize();
        }
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://github.com");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("login_field")).SendKeys("testautomationuser");
            driver.FindElement(By.Id("password")).SendKeys("testautomationuser");
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
