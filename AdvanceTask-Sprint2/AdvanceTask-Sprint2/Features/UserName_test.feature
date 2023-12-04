Feature: UserName_test

As a Skillswap user I would be able to see the UserName details on the Profile Page.
So that I can change the Availability, Hours, Earn Target status.

@order1
 Scenario: 01 - Edit the Users Availability Status 
Given User logs into Mars portal
And User navigates to Profile page
When User able to update the desired Availaility time
Then User should see a success message confirming Availability status change

@order2
Scenario Outline: 02 - Edit the Users Hours Status 
Given User logs into Mars portal
And User navigates to Profile page
When User able to update the desired Hours
Then User should see a success message confirming Hours status change

@order3
Scenario Outline: 03 - Edit the Users Earn Target Status
Given User logs into Mars portal
And User navigates to Profile page
When User able to update the desired Target
Then User should see a success message confirming Target status change

@order4
Scenario Outline: 04 - Edit the Users First and Last Name
Given User logs into Mars portal
And User navigates to Profile page
Then User able to Edit the First and Last Name

