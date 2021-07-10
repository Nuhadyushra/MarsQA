Feature: certificate

#
#Scenario: Validate if seller is able to add certificate
#	Given seller clicks on certificate from menu
#    When  seller clicks on AddNew button
#	| Add Certificate, certified from and year fiel |
#	| click on Add button                           |
#	Then pop-up message is displayed " 'Certificate Name' has been added to your certificates "
Scenario: Seller is able to Add new Certificate'
Given Seller is able to Add new Certificate

Scenario: Seller is able to edit Certificate
Given Seller is able to update certificate

Scenario: Seller is able to delete certificate
Given seller is able to delete certificate


#Scenario: Validate if user is able to cancel adding certificate process
#	Given seller clicks on certificate from menu
#	When  seller clicks on AddNew button
#	| click on cancel button                        |
#    Then Seller can see AddNew button
#
#Scenario: Validate if seller is able to Add same Certificate name, certified from and same year again
#	Given seller clicks on certificate from menu
#	When  seller clicks on AddNew button
#	| Add same Certificate name, certification  from and certification year|
#	| click on Add button                  |
#	Then pop-up message is displayed " This certificate is already exist in your skill list "
#
#Scenario: Validate if seller is able to Add same certificate with different certified from and year again
#	Given seller clicks on certificate from menu
#	When  seller clicks on AddNew button
#	| Add same certificate name, certified from and different certification year [combination of all sets possible]|
#	| click on Add button                       |
#	Then pop-up message is displayed " 'certification name' has been added to your cetificates successfully "
#
#Scenario: Validate if seller is able to Add more than 20 certificates
#	Given seller clicks on certificates from menu
#	When  seller wants to add 21st certiicate
#	Then seller AddNew button is visible
#
#Scenario: Validate if seller can add certificate without filling all fields
#	Given seller click on certificate from menu
#	When seller leaves one of the text boxes empty
#	Then pop-up message is displayed " Please enter certification name , certificate from and certificate year "