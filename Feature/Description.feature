Feature: SpecFlowFeature

Scenario: Validate if seller is able to click on profile
	Given seller has logged in successfully
	When seller click on profile menu
	Then seller is able to see profile

Scenario: Validate if seller is able to Save description
	Given seller click on a pencil icon beside description
	And seller is able to write 600 words in description text box
	When seller click on save button
	Then pop-up message is displayed " Description has been saved succesfully "

Scenario: Validate if seller is able to edit description
	Given seller click on a pencil icon beside description
	And seller is able to edit 600 or less words in description text box
	When seller click on save button
	Then pop-up message is displayed " Description has been saved succesfully "

Scenario: Seller is able to save empty text box
	Given seller click on a pencil icon beside description
	And seller removes everything from  description text box
	When seller click on save button
	Then pop-up message is displayed " Please, a description is required "










	






