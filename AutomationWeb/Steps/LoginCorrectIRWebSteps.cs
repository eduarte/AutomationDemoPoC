using AutomationDemoPoC.Base;
using AutomationWeb.Helper;
using System;
using TechTalk.SpecFlow;

namespace AutomationWeb.Steps
{
    [Binding]
    public class LoginCorrectIRWebSteps : BaseTestWebDrive
    {
        private  LoginWebForm _loginWebForm;

        [Given(@"I have opened CorrectIR Web")]
        public void GivenIHaveOpenedCorrectIRWeb()
        {
            _loginWebForm = new LoginWebForm(_driver);
        }
        
        [When(@"I login with Username ""(.*)""")]
        public void WhenILoginWithUsername(string username)
        {
            _loginWebForm.EnterUsername(username);
        }
        
        [When(@"with the Password ""(.*)""")]
        public void WhenWithThePassword(string password)
        {
            _loginWebForm.EnterPassword(password);
        }
        
        [When(@"Click Login")]
        public void WhenClickLogin()
        {
            _loginWebForm.ClickLogin();
        }
        
        [Then(@"I should be able to see the home screen")]
        public void ThenIShouldBeAbleToSeeTheHomeScreen()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
