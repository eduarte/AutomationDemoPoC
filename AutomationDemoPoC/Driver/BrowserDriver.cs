using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Configuration;

namespace AutomationDemoPoC.Driver
{
    public class BrowserDriver
    {
        private IWebDriver _driver;
        private readonly string driversPath = @"C:\Automation\Drivers\";

        public IWebDriver GetBrowser(string browserName)
        {
            if (browserName.ToLower().Contains("firefox"))
            {
                FirefoxBrowser();
            }
            else
            {
                ChromeBrowser();
            }
            _driver.Manage().Window.Maximize();
            //_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            _driver.Navigate().GoToUrl(new Uri(ConfigurationManager.AppSettings["correctIRWeb"]));
            return _driver;
        }

        private void FirefoxBrowser()
        {
            FirefoxDriverService firefoxService = FirefoxDriverService.CreateDefaultService(driversPath, "geckodriver.exe");
            firefoxService.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            _driver = new FirefoxDriver(firefoxService);
        }

        private void ChromeBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("\"no-sandbox\"");
            _driver = new ChromeDriver(driversPath,options);
        }

    }
}
