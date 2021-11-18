using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        // web driver
        IWebDriver driver;

     
        


        void Init()
        {
            driver = new ChromeDriver(".");
        }

        void Exec()
        {
            // navigate to the google page

            driver.Navigate().GoToUrl("https:\\www.google.com");

            // find the element

            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Selenium rocks");

            IWebElement searchButton = driver.FindElements(By.Name("btnK")).ToArray()[1];


            searchButton.Click();
        }


        void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}