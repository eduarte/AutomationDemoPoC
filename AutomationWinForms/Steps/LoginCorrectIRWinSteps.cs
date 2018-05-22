using AutomationDemoPoC.Base;
using AutomationDemoPoC.Helper;
using System;
using TechTalk.SpecFlow;

namespace AutomationDemoPoC.Steps
{
    [Binding]
    public class LoginCorrectIRWinSteps : BaseTestWinDrive
    {

        private readonly LoginForm _loginForm;

        public LoginCorrectIRWinSteps(LoginForm loginForm)
        {
            _loginForm = loginForm;
        }

        [Given(@"I have launch CorrectIR")]
        public void GivenIHaveLaunchCorrectIR()
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
            Console.WriteLine("Hello");
        }
    }
}
