using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Configuration;

namespace AutomationDemoPoC.Driver
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class WinAppDriver : IDisposable 
    {
        private WindowsDriver<WindowsElement> _driver;

        public WindowsDriver<WindowsElement> Current
        {
            get
            {
                if (_driver != null)
                {
                    return _driver;
                }

                var correctIRPath = new Uri(ConfigurationManager.AppSettings["correctIRPath"]);
                var capabilities = new DesiredCapabilities();
                capabilities.SetCapability("app", correctIRPath);
                _driver = new WindowsDriver<WindowsElement>(new Uri(ConfigurationManager.AppSettings["winAppUri"]), capabilities);

                return _driver;
            }
        }



        public void Dispose()
        {
            _driver.Dispose();
        }
    }
}
