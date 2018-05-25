using AutomationDemoPoC.Helper;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using TechTalk.SpecFlow;

namespace AutomationDemoPoC.Steps
{
    [Binding]
    public class LoginWinSteps 
    {

        private readonly LoginForm _loginForm;
        private static Process _driver;

        public LoginWinSteps(LoginForm loginForm)
        {
            _loginForm = loginForm;
        }

        [BeforeTestRun]
        public static void StartWinAppDriver()
        {
            try
            {
                _driver = Process.Start(ConfigurationManager.AppSettings["winAppPath"]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not locate WinAppDriver.exe, get it from https://github.com/Microsoft/WinAppDriver/releases and change the winAppPath in app.settings accordingly");
                throw new FileNotFoundException("Could not locate File WinAppDriver.exe", e);
            }
        }

        [AfterTestRun]
        public static void KillWinAppDriver()
        {
            _driver.Kill();
        }

        [Given(@"I have launch the WinApplication")]
        public void GivenIHaveLaunchTheWinApplication()
        {
            Console.WriteLine("Hello");
        }
        
        [When(@"I login with Username ""(.*)""")]
        public void WhenILoginWithUsername(string username)
        {
            
            _loginForm.EnterUserName(username);
        }
        
        [When(@"with the Password ""(.*)""")]
        public void WhenWithThePassword(string password)
        {
            _loginForm.EnterPassword(password);
        }
        
        [When(@"the Server ""(.*)""")]
        public void WhenTheServer(string server)
        {
            _loginForm.EnterServer(server);
        }
        
        [When(@"I click ""(.*)"" button")]
        public void WhenIClickButton(string p0)
        {
            _loginForm.ClickOkButton();
        }
        
        [Then(@"I should be able to see the home screen")]
        public void ThenIShouldBeAbleToSeeTheHomeScreen()
        {
          
            _loginForm.spreadsheet();
        }
    }
}
