using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;
using FluentAssertions;

namespace WebDriver3
{
    public class WebDriver
    {
        [Test]
        public void GoogleSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://cloud.google.com/products/calculator");
            driver.Manage().Window.Maximize();

            IWebElement txtField = driver.FindElement(By.XPath("//*[@id=\"ucj-1\"]/div/div/div/div/div/div/div/div[2]/div[1]/div/div[2]/div/button"));
            txtField.Click();

            Thread.Sleep(3000);

            IWebElement secondButton = driver.FindElement(By.XPath("//div[@role='button' and .//h2[text()='Compute Engine']]"));
            secondButton.Click();

            Thread.Sleep(3000);

            IWebElement inputField = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[2]/div/div/div/div/div[2]/div[1]/div[3]/div[3]/button/div"));

            for (int i = 0; i < 3; i++)
            {
                inputField.Click();
            }

            IWebElement firstDropdown = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div"));
            firstDropdown.Click();
            IWebElement firstOption = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]"));
            firstOption.Click();

            IWebElement secondSwitch = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[21]/div/div/div[1]/div/div/span/div/button/div/span[1]"));
            secondSwitch.Click();
            Thread.Sleep(3000);

            IWebElement thirdDropdown = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div"));
            thirdDropdown.Click();
            IWebElement thirdOption = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[2]"));
            thirdOption.Click();

            IWebElement fourthDropdown = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div"));
            fourthDropdown.Click();
            IWebElement fourthOption = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]"));
            fourthOption.Click();

            IWebElement fifthDropdown = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[1]/div"));
            fifthDropdown.Click();
            IWebElement fifthOption = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[29]/div/div[1]/div/div/div/div[2]/ul/li[5]"));
            fifthOption.Click();
            Thread.Sleep(4000);

            IWebElement shareButton = driver.FindElement(By.XPath("//*[@id=\"ow5\"]/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[2]/div/button/span[5]/i"));
            shareButton.Click();    
            Thread.Sleep(3000);
            IWebElement firstPagePriceElement = driver.FindElement(By.XPath("//*[@id='yDmH0d']/div[5]/div[2]/div/div/div/div[2]/div[1]/div/div/label"));
            string firstPagePrice = firstPagePriceElement.Text;

            IWebElement estimateButton = driver.FindElement(By.XPath("//*[@id=\"yDmH0d\"]/div[5]/div[2]/div/div/div/div[1]/a"));
            estimateButton.Click();

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            IWebElement secondPagePriceElement = driver.FindElement(By.XPath("//*[@id='yDmH0d']/c-wiz[1]/div/div/div/div/div/div[1]/div/div[1]/div[1]/h4"));
            string secondPagePrice = secondPagePriceElement.Text;

            string firstPagePriceNumeric = new string(firstPagePrice.Where(char.IsDigit).ToArray());
            string secondPagePriceNumeric = new string(secondPagePrice.Where(char.IsDigit).ToArray());

            if (firstPagePriceNumeric == secondPagePriceNumeric)
            {
                Console.WriteLine("The prices match: " + firstPagePrice);
            }
            else
            {
                Console.WriteLine("The prices do not match. First page: " + firstPagePrice + ", Second page: " + secondPagePrice);
            }
        }
    }
}