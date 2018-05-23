
using AutomationDemoPoC.Drive;


namespace AutomationDemoPoC.Helper
{
    public class LoginForm
    {
        private readonly WinAppDriver _driver;

        private readonly string userNameID = "username";
        private readonly string passwordID = "password";
        private readonly string serverID = "servers";
        private readonly string oKButton = "ok";

        public LoginForm(WinAppDriver driver)
        {
            _driver = driver;
        }


        public void EnterUserName(string username)
        {
            _driver.Current.FindElementByAccessibilityId(userNameID).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.Current.FindElementByAccessibilityId(passwordID).SendKeys(password);
        }

        public void EnterServer(string server)
        {
            _driver.Current.FindElementByAccessibilityId(serverID).SendKeys(server);
        }

        public void ClickOkButton()
        {
            _driver.Current.FindElementByAccessibilityId(oKButton).Click();
        }

    }
}