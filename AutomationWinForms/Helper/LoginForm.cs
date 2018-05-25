
using AutomationDemoPoC.Drive;
using System.Threading;

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

        public void SelectFurnace()
        {
            Thread.Sleep(5000);
            var group = _driver.Current.FindElementByAccessibilityId("groupControl1");
            var edits = group.FindElementsByTagName("Edit");
            edits[5].SendKeys("Box Header");
            
        }

        public void SelectCamara()
        {

            var group = _driver.Current.FindElementByAccessibilityId("groupControl1");
            var edits = group.FindElementsByTagName("Edit");
            edits[3].SendKeys("FLIR GF309 10000001");

        }

        public void spreadsheet()
        {
            _driver.Current.FindElementByName("Furnace Analysis").Click();
            var spread = _driver.Current.FindElementByAccessibilityId("spreadsheet");
            var temp = spread.GetType();

        }


    }
}