using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver(@"C:\Users\Admin\Documents\Visual Studio 2017\Projects\UnitTestWeb\UnitTestWeb");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://github.com");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("login_field")).SendKeys("testautomationuser");
            driver.FindElement(By.Id("password")).SendKeys("testautomationuser");
            driver.FindElement(By.Name("commit")).Click();

        }
    }
}
