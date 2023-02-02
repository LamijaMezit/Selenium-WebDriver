using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumWebDriver.cs
{
    class Program
    {

        IWebDriver driver = new ChromeDriver();

      

        private static void Main (string[] args)
        {

        }

        [SetUp]

        public void StartBrowser()
        {
            driver.Navigate().GoToUrl("https://fit.ba/");
            Console.WriteLine("Open browser");
        }

        [Test]
        public void PerformTheTest()
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/nav/div/button"));
            element.Click();
            Console.WriteLine("The test is in execution.");

        }
        [TearDown]
        public void Finish()
        {
            driver.Close();
            Console.WriteLine("The test was successfully completed.");
           
        }

        
    }
}
