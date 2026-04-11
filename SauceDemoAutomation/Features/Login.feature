Feature: Login functionality

Scenario: Successful login
   Given user navigates to SauceDemo
   When user enters valid username and password
   Then user should see products page