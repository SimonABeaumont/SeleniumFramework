Feature: Navigation
	As a user on the BBC website
	I am able to navigate around the site as expected

@Selenium
Scenario: Navigation Feature - Navigate to News
	Given That I have gone to the BBC website
	And I choose to go to 'NewsHome'
	Then I am taken to the 'NewsHome' page
	When I go back from the 'NewsHome' page
	Then I am on the 'BBCHome' page

@Selenium
Scenario: Navigation Feature - Navigate to Sports
	Given That I have gone to the BBC website
	And I choose to go to 'SportsHome'
	Then I am taken to the 'SportsHome' page
	When I choose to go to 'BBCHome'
	Then I am taken to the 'BBCHome' page

@Selenium
Scenario: Navigation Feature - Navigate to Football
	Given That I have gone to the BBC website
	And I choose to go to 'SportsHome'
	Then I am taken to the 'SportsHome' page
	When I choose to go to 'FootballHome'
	Then I am taken to the 'FootballHome' page
	When I choose to go to 'BBCHome'
	Then I am taken to the 'BBCHome' page


