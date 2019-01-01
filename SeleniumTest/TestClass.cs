using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    [TestFixture]
    public class TestClass
    {
        IWebDriver driver = null;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.guru99.com/popup.php";
        }

        [Test]
        public void TestMethod()
        {
            string Currentwindow = driver.CurrentWindowHandle;

            driver.FindElement(By.LinkText("Click Here")).Click();
            driver.FindElement(By.LinkText("Click Here")).Click();
            driver.FindElement(By.LinkText("Click Here")).Click();
            IList<string> currentWindowHandles = driver.WindowHandles.ToList();
            foreach(string asdf in currentWindowHandles)
            {
                driver.SwitchTo().Window(asdf);
            }

            driver.SwitchTo().Window(Currentwindow);
        }
    }
}
