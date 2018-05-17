using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sample
{
    /// <summary>
    /// http://toolsqa.com/selenium-webdriver/c-sharp/browser-navigation-commands-in-c/
    /// C＃中的浏览器导航命令
    /// </summary>
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
