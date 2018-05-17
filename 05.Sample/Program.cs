using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sample
{
    /// <summary>
    /// http://toolsqa.com/selenium-webdriver/c-sharp/webelement-commands-in-c/
    /// C＃中的WebElement命令
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.FindElement(By.Id("userName")).Clear();
            driver.FindElement(By.Id("userName")).SendKeys("ToolsQA");
            driver.FindElement(By.Id("userName")).Click();
            bool displayed = driver.FindElement(By.Id("userName")).Displayed;
            bool enabled = driver.FindElement(By.Id("userName")).Enabled;
            bool selected = driver.FindElement(By.Id("userName")).Selected;
            driver.FindElement(By.Id("userName")).Submit();
            string text = driver.FindElement(By.Id("userName")).Text;
            string tagName = driver.FindElement(By.Id("userName")).TagName;
            string attvalue = driver.FindElement(By.Id("username")).GetAttribute("name");
            var size = driver.FindElement(By.Id("username")).Size;
            var location = driver.FindElement(By.Id("username")).Location;

            driver.Close();
            driver.Quit();
        }
    }
}
