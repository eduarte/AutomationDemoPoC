Feature: Login
	In use CorrectIR WinForm
	As a superAdmin user
	I want to be able to login into the application

@mytag
Scenario: Valid Credentials
	Given I have launch CorrectIR 
	When I login with Username "superadmin"
		And with the Password "password"
		And the Server "http://localhost:60000/API/"
		And I click "OK" button
	Then I should be able to see the home screen
