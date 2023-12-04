Feature: Skill_Test

As a Skillswap user I would be able to show what Skills I know.
So that the people seeking for skills can look at what details I hold.

@order1
 Scenario:  01 - Delete an existing Skill
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Skill tab
When User deletes all the skill records

@order2
Scenario Outline: 02 - Add new Skill
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Skill tab
When User adds a new Skill record
Then User should see a success message confirming the adding skill

@order3
Scenario Outline: 03 - Updating a Skill
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Skill tab
When User updates a Skill record
Then User should see a success message confirming the updating skill

@order4
Scenario Outline: 04 - Deleting a Skill
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Skill tab
When User deletes a Skill record
Then User should see a success message confirming the deleting skill




