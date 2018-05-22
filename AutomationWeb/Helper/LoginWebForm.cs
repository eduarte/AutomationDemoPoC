using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationWeb.Helper
{
    public class LoginWebForm 
    {
        [FindsBy(How = How.Id, Using = "UserName")]
        private IWebElement UsernameElement { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        private  IWebElement PasswordElement { get; set; }

        [FindsBy(How = How.Id, Using = "login")]
        private readonly IWebElement loginBtn;

        private readonly IWebDriver _driver;

        public LoginWebForm(IWebDriver browserDriver)
        {
            _driver = browserDriver;
            PageFactory.InitElements(_driver, this);
        }

        public void EnterUsername(string username) {
            UsernameElement.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordElement.SendKeys(password);
        }

        public void ClickLogin() {
            loginBtn.Click();
        }
    }
}
