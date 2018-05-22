using AutomationDemoPoC.Driver;
using OpenQA.Selenium;
using System.Configuration;
using TechTalk.SpecFlow;


namespace AutomationDemoPoC.Base
{
    public class BaseTestWebDrive
    {
        protected static IWebDriver _driver;

        public BaseTestWebDrive()
        {
            Setup();
        }
       [BeforeTestRun]
        public static void Setup() {
            BrowserDriver browser = new BrowserDriver();
            string browserType = ConfigurationManager.AppSettings["browserType"];
            _driver = browser.GetBrowser(browserType);
        }

       [AfterTestRun]
        public static void KillBrowser()
        {
            _driver.Quit();
        }
    }
}
