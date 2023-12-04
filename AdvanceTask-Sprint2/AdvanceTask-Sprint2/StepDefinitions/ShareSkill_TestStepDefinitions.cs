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
    public class ShareSkill_TestStepDefinitions : BaseSetup
    {
        SignIn SignInObj;
        ShareSkillSteps ShareSkillStepsObj;
        LoginPage LoginPageObj;
        ProfileTabPageSteps profileTabPageStepsObj;
        ResetShareSkillState ResetShareSkillStateObj;
        ShareSkillAssertion ShareSkillAssertionObj;
        ShareSkillComponent ShareSkillComponentObj;
        public ShareSkill_TestStepDefinitions()
        {
            SignInObj = new SignIn();
            ShareSkillStepsObj = new ShareSkillSteps();
            profileTabPageStepsObj = new ProfileTabPageSteps();
            LoginPageObj = new LoginPage();
            ResetShareSkillStateObj = new ResetShareSkillState();
            ShareSkillAssertionObj = new ShareSkillAssertion();
            ShareSkillComponentObj = new ShareSkillComponent();
        }

        [Given(@"User selects the Manage Listings tab")]
        public void GivenUserSelectsTheManageListingsTab()
        {
            ResetShareSkillStateObj.ClickOnManageListing();
            Thread.Sleep(5000);
        }

        [When(@"User deletes the skills from the Manage Listings")]
        public void WhenUserDeletesTheSkillsFromTheManageListings()
        {
            ResetShareSkillStateObj.DeleteAllSkills();
            Thread.Sleep(4000);
            string actualmessage = ResetShareSkillStateObj.GetMessageBoxText();
            Console.WriteLine(actualmessage);
        }

        [Then(@"User should see a deleted success message confirming the deletion")]
        public void ThenUserShouldSeeADeletedSuccessMessageConfirmingTheDeletion()
        {
            ShareSkillAssertionObj.AssertDeletedShareSkill();
        }

        [When(@"User clicks on Share Skill button")]
        public void GivenUserClicksOnShareSkillButton()
        {
            profileTabPageStepsObj.clickShareSkill();
        }
      
        [Then(@"User adds a new Share Skills")]
        public void WhenUserAddsANewShareSkills()
        {
            ShareSkillStepsObj.AddShareSkill();
        }

        [Then(@"User Updates a Skill from Manage Listings")]
        public void WhenUserUpdatesASkillFromManageListings()
        {
            ShareSkillStepsObj.UpdateShareSkill();
        }

    }
}
