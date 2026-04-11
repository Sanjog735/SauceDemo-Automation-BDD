using OpenQA.Selenium;
using Reqnroll;
using SauceDemoAutomation.Config;
using SauceDemoAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoAutomation.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        IWebDriver driver = TestHooks.driver;
        LoginPage loginPage;

        [Given("user navigates to SauceDemo")]
        public void GivenUserNavigatesToSauceDemo()
        {
            var url = ConfigHelper.GetBaseUrl();
            driver.Navigate().GoToUrl(url);
        }

        [When("user enters valid username and password")]
        public void WhenUserEntersValidUsernameAndPassword()
        {
            var userName = ConfigHelper.GetUsername();
            var passWord = ConfigHelper.GetPassword();

            loginPage = new LoginPage(driver);
            loginPage.EnterUserName(userName);
            loginPage.EnterPassword(passWord);
            loginPage.ClickLoginBtn();
        }

        [Then("user should see products page")]
        public void ThenUserShouldSeeProductsPage()
        {
            Assert.That(driver.Title.Contains("Swag Labs"));
        }

    }
}
