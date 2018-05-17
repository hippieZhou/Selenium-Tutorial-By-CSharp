using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            //driver.Url = "http://www.bing.com";
            driver.Navigate().GoToUrl("http://demoqa.com");
            driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
        }
    }
}
