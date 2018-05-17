using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sample
{
    /// <summary>
    /// 鼠标右键执行 Run Tests
    /// </summary>
    class NUnitTest
    {
        //public void TestApp()
        //{
        //    IWebDriver driver = new FirefoxDriver();
        //    driver.Url = "http://www.demoqa.com";
        //    driver.Close();
        //}

        IWebDriver driver;
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.demoqa.com";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}
