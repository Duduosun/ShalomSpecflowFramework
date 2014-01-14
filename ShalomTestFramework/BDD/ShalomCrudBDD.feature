Feature: ShalomCrudBDD
	As a User
	I want to visit Shalom Web App
	So as to search and read a Study - ShalomRead
	So as to create and read a Study - ShalomCreate
	So as to edit and read a Study - ShalomUpdate
	So as to search and delete a Study - ShalomDelete

@read
Scenario: ShalomRead
	Given Shalom Web App
	When I search a Study
	Then I can access the Study
	And I can read the Study

@create
Scenario: ShalomCreate
	Given Shalom Web App
	When I create a Study
	Then I can search the Study
	And I can read the Study

@update
	Scenario: ShalomUpdate
	Given Shalom Web App
	When I update a Study
	Then I can search the Study
	And I can read the Study

@delete
	Scenario: ShalomDelete
	Given Shalom Web App
	When I delete a Study
	Then I cannot access the Study
	And I cannot read the Study