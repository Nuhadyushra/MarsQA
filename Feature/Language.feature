Feature: Language
	Scenario: Validate if seller is able to Add new Language
	Given seller is able to add new language
	
#
#Scenario: Validate if user is able to cancel adding Language process
#	Given seller clicks on Language from menu
#	When  seller clicks on AddNew button
#	| click on cancel button                        |
#   
#Scenario: Validate if seller is able to Add same Language with same level again
#	Given seller clicks on language from menu
#	When  seller clicks on AddNew button
#	| Add same language and choose same language level |
#	| click on Add button                              |
#	
#
#Scenario: Validate if seller is able to Add same Language with different level again
#	Given seller clicks on language from menu
#	When  seller clicks on AddNew button
#	| Add same language and choose different language level |
#	| click on Add button                                   |
#	Then pop-up message is displayed " Duplicate Data "
#
#Scenario: Validate if seller is able to Add more than 4 languages
#	Given seller clicks on language from menu
#	When  seller wants to add 5th language
#	Then seller AddNew button is not visible

Scenario: Validate if seller is able to Update Languages
	Given seller is able to update language
	
#
#Scenario: Validate if seller can add language without filling all fields
#	Given seller click on language from menu
	

Scenario: Validate if seller is able to Delete Languages
	Given seller is able to delete language
