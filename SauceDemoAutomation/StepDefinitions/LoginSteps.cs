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

        [Given("the user navigates to the SauceDemo Login Page")]
        public void GivenTheUserNavigatesToTheSauceDemoLoginPage()
        {
            driver.Navigate().GoToUrl(ConfigHelper.GetBaseUrl());
        }
        [When("the user provides the following credentials")]
        public void WhenTheUserProvidesTheFollowingCredentials(DataTable table)
        {
            var credentials = table.Rows[0];
            var userName = credentials["username"];
            var passWord = credentials["password"];

            loginPage = new LoginPage(driver);
            loginPage.EnterUserName(userName);
            loginPage.EnterPassword(passWord);
        }
        [When("the user clicks the login button")]
        public void WhenTheUserClicksTheLoginButton()
        {
            loginPage.ClickLoginBtn();
        }
        [Then("the user should see the following error message")]
        public void ThenTheUserShouldSeeTheFollowingErrorMessage(DataTable table)
        {
            var expectedError = table.Rows[0]["error_message"];
            var actualError = loginPage.GetErrorMessage();
            Assert.That(expectedError, Is.EqualTo(actualError));
        }
        [Then("the user should be redirected to the products page")]
        public void ThenTheUserShouldBeRedirectedToTheProductsPage()
        {
            Assert.That(driver.Title.Contains("Swag Labs"));
        }
    }
}
