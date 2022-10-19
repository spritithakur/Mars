Feature: ProfileFeature

Below are the running Test cases for profile page

@tag1
Scenario: 01) Add Profile Name
	Given I Logged into LocalHost successfully
	When I Add First name and Last name in profile page
	Then The Profile name should be added successfully

Scenario: 02) Add Availability on profile
    Given  I Logged into LocalHost successfully
	When I Select Full time availability
	Then The Availability should be updated successfully

Scenario:  03) Add Description on Profile
    Given  I Logged into LocalHost successfully
	When I Added Description on profile page
	Then The Description should be updated successfully

Scenario: 04) Add Language on Profile
    Given  I Logged into LocalHost successfully
	When Add New language details on profile page
	Then The Language should be added successfully

Scenario: 05) Edit the recent added Language on Profile
    Given  I Logged into LocalHost successfully
	When Edit the existing language details on profile page
	Then French has been updated to your languages


Scenario: 06) Delete the Edited Language in Profile
    Given I Logged into LocalHost successfully
	When Delete the exisitng language record on profile page
	Then French has been deleted from your languages