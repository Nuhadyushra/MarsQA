Feature: Education

Scenario: Seller is able to add Education
Given Seller clicks on Education tab
When seller wants to add Education
|Add Details for Education|
Then seller clicks on Add button

Scenario: Seller is able to Update Education
Given Seller clicks on Education tab
When seller wants to update Education
|click on pencil icon to update  |
|Update Details for Education|
Then seller clicks on Update button

Scenario: Seller is able to delete Education
Given Seller clicks on Education tab
When seller wants to delete Education
Then seller clicks on cross icon button