using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sample
{
    class FindElementCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.baidu.com";
            driver.FindElement(By.Id("kw")).SendKeys("hippie");
            driver.FindElement(By.Id("su")).Click();
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.baidu.com";
            driver.FindElement(By.Id("kw"));
            Console.WriteLine("Partical like test Pass");

            string sClass = driver.FindElement(By.Name("tj_trnews")).ToString();
            Console.WriteLine(sClass);

            driver.FindElement(By.LinkText("新闻")).Click();
        }
    }
}
