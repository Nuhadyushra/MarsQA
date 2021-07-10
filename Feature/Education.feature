Feature: Education

Scenario: Seller is able to add Education
Given Seller clicks on certificate tab
When seller wants to add certificate
|Add Details for certification|
Then seller clicks on Add button

Scenario: Seller is able to Update Education
Given Seller clicks on certificate tab
When seller wants to update certificate
|click on pencil icon to update  |
|Update Details for certification|
Then seller clicks on Update button

Scenario: Seller is able to delete Education
Given Seller clicks on certificate tab
When seller wants to delete certificate
Then seller clicks on cross icon button