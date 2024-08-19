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


            //IWebElement inputField = driver.FindElement(By.CssSelector("input#c19"));
            //inputField.Clear();
            //inputField.SendKeys("4");

            //IWebElement firstDropdown = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[1]/div"));
            //firstDropdown.Click();
            //IWebElement firstOption = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[11]/div/div/div[2]/div/div[1]/div[3]/div/div/div/div[2]/ul/li[7]"));
            //firstOption.Click();

            //IWebElement secondDropdown = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[1]/div"));
            //secondDropdown.Click();
            //IWebElement secondOption = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[23]/div/div[1]/div/div/div/div[2]/ul/li[2]"));
            //secondOption.Click();

            //IWebElement thirdDropdown = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[1]/div"));
            //thirdDropdown.Click();
            //IWebElement thirdOption = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[1]/div/div[2]/div[3]/div[27]/div/div[1]/div/div/div/div[2]/ul/li[3]"));
            //thirdOption.Click();

            //IWebElement calculateButton = driver.FindElement(By.XPath("//*[@id='ow5']/div/div/div/div/div/div/div[2]/div[1]/div/div[4]/div[2]/div[2]/div/button/span[2]"));
            //calculateButton.Click();

            //IWebElement finalButton = driver.FindElement(By.XPath("//*[@id='yDmH0d']/div[6]/div[2]/div/div/div/div[1]/a"));
            //finalButton.Click();

            //string currentUrl = driver.Url;
            //currentUrl.Should().Contain("cloud.google.com");

            //IWebElement txtFieldTitle = driver.FindElement(By.Name("PostForm[name]"));
            //string expectedTitle = "how to gain dominance among developers";
            //txtFieldTitle.SendKeys(expectedTitle);

            //IWebElement txtPasteExpiration = driver.FindElement(By.XPath("//*[@id="yDmH0d"]/div[5]/div[2]/div/div/div/div[2]/div/div/div[1]/div/div/div"));
            //txtPasteExpiration.Click();
            //IWebElement option10Minutes = driver.FindElement(By.XPath("//li[contains(text(), '10 Minutes')]"));
            //option10Minutes.Click();

            //IWebElement txtHighlighting = driver.FindElement(By.XPath("//*[@id='select2-postform-format-container']"));
            //txtHighlighting.Click();
            //IWebElement txtHighlighting1 = driver.FindElement(By.XPath("/html/body/span[2]/span/span[1]/input"));
            //txtHighlighting1.SendKeys("Bash");
            //txtHighlighting1.SendKeys(Keys.Enter);

            //IWebElement btnCreate = driver.FindElement(By.XPath("//*[@id='w0']/div[5]/div[1]/div[10]/button"));
            //btnCreate.Click();

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //IWebElement newPageTitle = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/h1"));
            //string actualTitle = newPageTitle.Text;
            //if (actualTitle == expectedTitle)
            //{
            //    Console.WriteLine("Title matches.");
            //}
            //else
            //{
            //    Console.WriteLine($"Title does not match. Expected: {expectedTitle}, Actual: {actualTitle}");
            //}

            //IWebElement newPageHighlighting = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[1]/div[1]/a[1]"));
            //string actualHighlighting = newPageHighlighting.Text;
            //if (actualHighlighting == "Bash")
            //{
            //    Console.WriteLine("Highlighting matches.");
            //}
            //else
            //{
            //    Console.WriteLine($"Highlighting does not match. Expected: Bash, Actual: {actualHighlighting}");
            //}

            //IWebElement newPageText = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/div[4]/div[2]/ol"));
            //string actualText = newPageText.Text;
            //if (actualText == expectedCode.Trim())
            //{
            //    Console.WriteLine("Code matches.");
            //}
            //else
            //{
            //    Console.WriteLine($"Code does not match. Expected: {expectedCode.Trim()}, Actual: {actualText}");
            //}
        }
    }
}