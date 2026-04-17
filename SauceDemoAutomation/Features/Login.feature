Feature: Validate Login functionality

Scenario: Login with Valid Credentials
	Given the user navigates to the SauceDemo Login Page
	When the user provides the following credentials
		| username      | password     |
		| standard_user | secret_sauce |
	And the user clicks the login button
	Then the user should be redirected to the products page

Scenario: Login with Invalid Credentials
	Given the user navigates to the SauceDemo Login Page
	When the user provides the following credentials
		| username        | password     |
		| locked_out_user | secret_sauce |
	And the user clicks the login button
	Then the user should see the following error message
		| error_message                                       |
		| Epic sadface: Sorry, this user has been locked out. |

Scenario: Login with null username
	Given the user navigates to the SauceDemo Login Page
	When the user provides the following credentials
		| username | password     |
		|          | secret_sauce |
	And the user clicks the login button
	Then the user should see the following error message
		| error_message                      |
		| Epic sadface: Username is required |

Scenario: Login with null password
	Given the user navigates to the SauceDemo Login Page
	When the user provides the following credentials
		| username      | password |
		| standard_user |          |
	And the user clicks the login button
	Then the user should see the following error message
		| error_message                      |
		| Epic sadface: Password is required |

Scenario: Login with null username and password
	Given the user navigates to the SauceDemo Login Page
	When the user provides the following credentials
		| username | password |
		|          |          |
	And the user clicks the login button
	Then the user should see the following error message
		| error_message                      |
		| Epic sadface: Username is required |
