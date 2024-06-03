using System.Xml.Linq;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SpecFlowProjectForQT.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.saucedemo.com/";
            Thread.Sleep(5000);

        }

        [When(@"Enter the login Credentials")]
        public void WhenEnterTheLoginCredentials()
        {
            driver.FindElement(By.Name("user-name")).SendKeys("standard_user");
            driver.FindElement(By.Name("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Name("login-button")).Click();
            Thread.Sleep(5000);
        }

        [Then(@"user on home page")]
        public void ThenUserOnHomePage()
        {
            Boolean homePage = driver.FindElement(By.XPath("//div[@class='inventory_container']")).Displayed;


            if (homePage == true)
            {
                Console.WriteLine("on home page");
            }
            else
            {
                Console.WriteLine("Failed to launch the page");
            }
            driver.Quit();

        }

    }
}