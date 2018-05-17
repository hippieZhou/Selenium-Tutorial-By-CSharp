using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sample
{
    class DriverCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";

            string title = driver.Title;
            Console.WriteLine($"Title of the page is:{title}");
            int titleLength = driver.Title.Length;
            Console.WriteLine($"Length of the title is:{titleLength}");
            string PageURL = driver.Url;
            Console.WriteLine($"URL of the page is : {PageURL}");
            int URLLength = driver.Url.Length;
            Console.WriteLine($"Length of the URL is : {URLLength}");
            string PageSource = driver.PageSource;
            int PageSourceLength = driver.PageSource.Length;
            Console.WriteLine($"Page Source of the page is : {PageSource}");
            Console.WriteLine($"Length of the Page Source is : {PageSourceLength}");
            driver.Quit();
        }

        [Test]
        public void Test02()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://demoqa.com/frames-and-windows/";
            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            //driver.Close();
        }
    }
}
