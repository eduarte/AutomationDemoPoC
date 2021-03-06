﻿using AutomationDemoPoC.Base;
using AutomationWeb.Helper;
using System;
using TechTalk.SpecFlow;

namespace AutomationWeb.Steps
{
    [Binding]
    public class LoginWebSteps : BaseTestWebDrive
    {
        private  LoginWebForm _loginWebForm;

        [Given(@"I have opened the Web Application")]
        public void GivenIHaveOpenedCorrectIRWeb()
        {
            _loginWebForm = new LoginWebForm(_driver);
            Console.WriteLine("Hello World!");
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
