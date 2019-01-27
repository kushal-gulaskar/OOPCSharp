using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
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
        static IWebDriver driver = null;

        [SetUp]
        public static void SetUp()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("os", "Windows");
            capability.SetCapability("os_version", "10");
            capability.SetCapability("browser", "Edge");
            capability.SetCapability("browser_version", "18.0");
            capability.SetCapability("browserstack.local", "false");
            capability.SetCapability("browserstack.user", "kushalgulaskar1");
            capability.SetCapability("browserstack.key", "D2viVx6apYjvx3y8KSp4");
            capability.SetCapability("browserstack.debug", "true");

     driver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), capability);
            driver.Url = "http://demo.guru99.com/popup.php";
        }

        [Test]
        public static void TestMethod()
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
