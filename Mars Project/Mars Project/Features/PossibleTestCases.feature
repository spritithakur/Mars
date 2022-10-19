Feature: PossibleTestCases

Below are the possible test cases for the profile page


@tag1
Scenario: Add Hours on Profile
    Given I Logged into LocalHost successfully
	When I Select More than 30 hours a week
	Then The hours should be updated successfully

Scenario: Add Earn target on Profile
    Given I Logged into LocalHost successfully
	When I Select Less than $500 per month
	Then The Earn Target should be updated successfully

Scenario:  Edit Language on Profile
    Given  I Logged into LocalHost successfully
	When Edit the language details on profile page
	Then The language should be updated successfully

Scenario: Delete the Added language on profile
    Given I Logged into LocalHost successfully
	When Delete the Language on profile page
	Then The language should be deleted successfully

Scenario: Add Skills on Profile
    Given  I Logged into LocalHost successfully
	When Add new Skill Details on Profile page
	Then The skills should be added successfully

Scenario: Edit Skills on Profile
    Given  I Logged into LocalHost successfully
	When Edit the Skills details on profile page
	Then The skills should be updated successfully

Scenario: Delete the added Skill on Profile
    Given  I Logged into LocalHost successfully
	When Delete the Skill on profile page
	Then The skill should be deleted successfully

Scenario: Add Education on Profile
    Given I Logged into LocalHost successfully
	When Add new Education Details on profile page
	Then The Education should be added successfully

Scenario: Edit Education on Profile
    Given  I Logged into LocalHost successfully
	When Edit the Education details on profile page
	Then The Education should be updated sucessfully

Scenario: Delete the Added Education on Profile
    Given  I Logged into LocalHost successfully
	When Delete the Education on profile page
	Then The Education should be deleted successfully

Scenario: Add Certification on Profile
    Given  I Logged into LocalHost successfully
	When Add New Certification details on profile page
	Then The certification should be added successfully

Scenario: Edit Certification on Profile
    Given I Logged into LocalHost successfully
	When Edit the Certification details on profile page
	Then The certification should be updated successfully

Scenario: Delete the Added certification on Profile
    Given I Logged into LocalHost successfully
	When Delete the certification on Profile Page
	Then The Certification should be deleted successfully

Scenario: Open the Chat on Profile
    Given I Logged into LocalHost successfully
	When I Navigate to the Message page
	Then The chats should be displayed successfully

Scenario: Go to the Profile page
    Given  I Logged into LocalHost successfully
	When I navigate to the Profile Page
	Then Profile page should be displayed successfully


Scenario: Change Password on Profile
    Given   I Logged into LocalHost successfully
	When I navigate to the Change Password 
	And Add Existing and New Passwprd on Profile page
	Then Password should be updated successfully

Scenario: Read the transactions on Profile
    Given  I Logged into LocalHost successfully
	When I Navigate to the Transaction page
	Then Transactions should be displayed on page

Scenario: Account Settings on Profile
    Given  I Logged into LocalHost successfully
	When I Navigate to the Account Settings page
	And I change Password on account settings page
	Then Password should be changed successfully

Scenario: Deactivate the Profile
    Given I Logged into LocalHost successfully
	When I Navigate to the Account Settings page
	And I deactivate the account on account settings page
	Then Account should be deactivated successfully

Scenario: Sign out from the Profile
    Given I Logged into LocalHost successfully
	When I Sign out on the Profile page
	Then Sign out should be successful and Navigate to the Home Page