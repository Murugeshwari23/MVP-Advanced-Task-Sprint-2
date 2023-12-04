using AdvanceTask_Sprint2.AssertHelpers;
using AdvanceTask_Sprint2.Components.ProfilePageTabComponents;
using AdvanceTask_Sprint2.Pages;
using AdvanceTask_Sprint2.Steps;
using AdvanceTask_Sprint2.TestModel;
using AdvanceTask_Sprint2.Utilities;
using System;
using TechTalk.SpecFlow;

namespace AdvanceTask_Sprint2.StepDefinitions
{
    [Binding]
    public class SearchSkill_TestStepDefinitions : BaseSetup
    {
        SignIn SignInObj;
        LoginPage LoginPageObj;
        SearchSkillSteps SearchSkillStepsObj;
        ProfileTabPageSteps profileTabPageStepsObj;
        SearchSkillsComponent SearchSkillsComponentObj;
        SearchSkillAssertions SearchSkillAssertionsObj;

        public SearchSkill_TestStepDefinitions()
        {
            SignInObj = new SignIn();
            LoginPageObj = new LoginPage();
            SearchSkillStepsObj = new SearchSkillSteps();
            profileTabPageStepsObj = new ProfileTabPageSteps();
            SearchSkillsComponentObj = new SearchSkillsComponent();
            SearchSkillAssertionsObj = new SearchSkillAssertions();
        }

        [When(@"User searches for skills")]
        public void WhenUserSearchesForSkills()
        {
            SearchSkillStepsObj.SearchBySkill();
            Thread.Sleep(5000);
        }

        [Then(@"User should be able to see a list of skills related to the search")]
        public void ThenUserShouldBeAbleToSeeAListOfSkillsRelatedToTheSearch()
        {
            List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\SearchSkill.json");
            foreach (SearchSkillModel searchskill in SearchSkillModelList)
            {
               
              SearchSkillAssertionsObj.SearchSkillAssert(searchskill);
            }
        }

        [When(@"User searches by Usernames")]
        public void WhenUserSearchesByUsernames()
        {
            SearchSkillStepsObj.SearchByUserName();
            Thread.Sleep(4000);
        }

        [Then(@"User should see a list of users with matching usernames")]
        public void ThenUserShouldSeeAListOfUsersWithMatchingUsernames()
        {
            List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\SearchByUserName.json");
            foreach (SearchSkillModel searchuserskill in SearchSkillModelList)
            {           
                SearchSkillAssertionsObj.SearchUserNameAssert(searchuserskill);
            }
        }

        [When(@"User searches by Category")]
        public void WhenUserSearchesByCategory()
        {
            SearchSkillStepsObj.SearchByCategoryclicked();
            Thread.Sleep(4000);
        }

        [Then(@"User should see a list of skills in that category")]
        public void ThenUserShouldSeeAListOfSkillsInThatCategory()
        {

            List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\CategoryData.json");
            foreach (SearchSkillModel categoryData in SearchSkillModelList)
            {
                
               SearchSkillAssertionsObj.SearchCategoryAssert(categoryData);
            }
        }

        [When(@"User searches using filters")]
        public void WhenUserSearchesUsingFilters()
        {
            SearchSkillStepsObj.SearchByFilterclicked();
            Thread.Sleep(4000);
        }

        [Then(@"User should see a refined list based on the applied filters")]
        public void ThenUserShouldSeeARefinedListBasedOnTheAppliedFilters()
        {
            List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\FilterData.json");
            foreach (SearchSkillModel filterData in SearchSkillModelList)
            {
               SearchSkillAssertionsObj.SearchFilterAssert(filterData);
            }
        }
    }
}
