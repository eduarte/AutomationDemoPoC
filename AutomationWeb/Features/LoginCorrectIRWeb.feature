Feature: LoginCorrectIRWeb
	In use CorrectIR Web
	As a superAdmin user
	I want to be able to login into the application

@mytag
Scenario: Valid Credentials
	Given I have opened CorrectIR Web 
	When I login with Username "superadmin"
		And with the Password "password"
		And Click Login
	Then I should be able to see the home screen
