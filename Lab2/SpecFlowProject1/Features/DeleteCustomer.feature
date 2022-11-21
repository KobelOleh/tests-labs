@setup_feature
Feature: DeleteCustomer

Scenario: Delete a customer
	Given open the XYZ Bank page
	And click on the Bank Manager Login button
	And click on the Customers button
	When click on the Delete button
	Then the result should be a list without one customer
