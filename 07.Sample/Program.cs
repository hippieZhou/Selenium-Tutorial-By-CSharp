using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sample
{
    /// <summary>
    /// http://toolsqa.com/selenium-webdriver/c-sharp/checkbox-radio-button-operations-c/
    /// C＃中的复选框和单选按钮操作
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Launch the URL
            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form";

            // Step 3 : Select the deselected Radio button (female) for category Sex (Use IsSelected method)
            // Storing all the elements under category 'Sex' in the list of WebLements	
            IList<IWebElement> rdBtn_Sex = driver.FindElements(By.Name("sex"));

            // Create a boolean variable which will hold the value (True/False)
            Boolean bValue = false;

            // This statement will return True, in case of first Radio button is selected
            bValue = rdBtn_Sex.ElementAt(0).Selected;

            // This will check that if the bValue is True means if the first radio button is selected
            if (bValue == true)
            {
                // This will select Second radio button, if the first radio button is selected by default
                rdBtn_Sex.ElementAt(1).Click();
            }
            else
            {
                // If the first radio button is not selected by default, the first will be selected
                rdBtn_Sex.ElementAt(0).Click();
            }

            //Step 4: Select the Third radio button for category 'Years of Exp' (Use Id attribute to select Radio button)
            IWebElement rdBtn_Exp = driver.FindElement(By.Id("exp-2"));
            rdBtn_Exp.Click();

            // Step 5: Check the checkbox 'Automation Tester' for category 'Profession'( Use Value attribute to match the selection)
            // Find the checkbox or radio button element by Name
            IList<IWebElement> chkBx_Profession = driver.FindElements(By.Name("profession"));
            // This will tell you the number of checkboxes are present

            int iSize = chkBx_Profession.Count;

            // Start the loop from first checkbox to last checkboxe
            for (int i = 0; i < iSize; i++)
            {
                // Store the checkbox name to the string variable, using 'Value' attribute
                String Value = chkBx_Profession.ElementAt(i).GetAttribute("value");

                // Select the checkbox it the value of the checkbox is same what you are looking for
                if (Value.Equals("Automation Tester"))
                {
                    chkBx_Profession.ElementAt(i).Click();
                    // This will take the execution out of for loop
                    break;
                }
            }

            // Step 6: Check the checkbox 'Selenium IDE' for category 'Automation Tool' (Use cssSelector)
            IWebElement oCheckBox = driver.FindElement(By.CssSelector("input[value='Selenium IDE']"));
            oCheckBox.Click();
            // Kill the browser
            driver.Close();
        }
    }
}
