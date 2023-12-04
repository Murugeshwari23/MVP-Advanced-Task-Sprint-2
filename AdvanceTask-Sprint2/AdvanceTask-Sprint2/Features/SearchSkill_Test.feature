Feature: SearchSkill_Test

As a Skillswap user I would be able to Search the Skills I want to learn.
So that I can seek for Skills that others users hold.

@order1
Scenario: 01 - Verify User able to Serach by Skill Name
Given User logs into Mars portal
And User navigates to Profile page
When User searches for skills
Then User should be able to see a list of skills related to the search

@order2
Scenario Outline: 02 - Verify User able to Serach by User Name
Given User logs into Mars portal
And User navigates to Profile page
When User searches by Usernames
Then User should see a list of users with matching usernames

@order3
Scenario Outline: 03 - Verify User able to Serach by Category
Given User logs into Mars portal
And User navigates to Profile page
When User searches by Category
Then User should see a list of skills in that category

@order4
Scenario Outline: 04 - Verify User able to Serach by using Filter option 
Given User logs into Mars portal
And User navigates to Profile page
When User searches using filters
Then User should see a refined list based on the applied filters