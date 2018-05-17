using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sample
{
    /// <summary>
    /// http://toolsqa.com/selenium-webdriver/c-sharp/set-up-selenium-webdriver-with-visual-studio-in-c/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * FirefoxDriver
             * ChromeDriver
             * EdgeDriver
             * InternetExplorerDriver
             */

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://demoqa.com/";

            
        }
    }
}
