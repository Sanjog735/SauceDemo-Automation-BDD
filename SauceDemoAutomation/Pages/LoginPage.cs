using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement username => driver.FindElement(By.Id("user-name"));
        IWebElement password => driver.FindElement(By.Id("password"));
        IWebElement loginBtn => driver.FindElement(By.Id("login-button"));

        public void EnterUserName(string name)
        {
            username.SendKeys(name);
        }
        public void EnterPassword(string pass)
        {
            password.SendKeys(pass);
        }
        public void ClickLoginBtn()
        {
            loginBtn.Click();
        }
    }
}
