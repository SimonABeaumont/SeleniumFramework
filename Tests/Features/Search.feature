Feature: Search
	As a user on the BBC website
	I am able to use the Search feature

@Selenium
Scenario: Search Feature - for valid results
	Given That I have gone to the BBC website
	And I choose to go to 'NewsHome'
	And I enter the search value 'Solvency II'
	And I click the search button
	Then successful search results are shown for 'Solvency II'


@Selenium
Scenario: Search Feature - for invalid resuls
	Given That I have gone to the BBC website
	And I choose to go to 'NewsHome'
	And I enter the search value '+---'
	And I click the search button
	Then unsucessful search message it shown


##@Selenium
##Scenario: Test Special characters such as *, %, ?, =, >, <, &, [ (and so ..)  in the search box
#
##@Selenium
##Scenario: Test a range of other non  alpha numeric charcters
#
##@Selenium
##Scenario: Upper and lower case, effect of search results
#
##@Selenium
##Scenario: Test the maximum number of characters the text box can take
#
##@Selenium
##Scenario: Click on a search result item and ensure it loads another page correctly
#
##@Selenium
##Scenario: Test search result options like AND and OR
#
##@Selenium
##Scenario: Search for a search item and check only 1 result returned
#
##@Selenium
##Scenario: Does the search button work pressing enter and can you tab to it and select it - accessibility
#
##@Selenium
##Scenario: Test for suggested results when typing a partial search item
#
##@Selenium
##Scenario: SQL Injection tests on search text box
#
##@Selenium
##Scenario: Copy and paste into the field
#
##@Selenium
##Scenario: Cross site scripting - try putting script tags in the search to test effect
#
