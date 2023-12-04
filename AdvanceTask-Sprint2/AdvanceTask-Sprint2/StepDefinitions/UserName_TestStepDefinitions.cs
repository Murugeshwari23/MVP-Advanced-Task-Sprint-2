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
    public class UserName_TestStepDefinitions : BaseSetup
    {
        SignIn SignInObj;
        LoginPage LoginPageObj;
        UserNameSteps UserNameStepsObj;
        ProfileTabPageSteps profileTabPageStepsObj;
        ProfileUserNameComponent ProfileUserNameComponentObj;
        UserNameAssertion UserNameAssertionObj;

        public UserName_TestStepDefinitions()
        {
            SignInObj = new SignIn();
            LoginPageObj = new LoginPage();
            UserNameStepsObj = new UserNameSteps();
            profileTabPageStepsObj = new ProfileTabPageSteps();
            ProfileUserNameComponentObj = new ProfileUserNameComponent();
            UserNameAssertionObj = new UserNameAssertion();
        }

        [When(@"User able to update the desired Availaility time")]
        public void GivenUserAbleToUpdateTheDesiredAvailailityTime()
        {
            UserNameStepsObj.AddAvailabilityTime();
        }

        [Then(@"User should see a success message confirming Availability status change")]
        public void WhenUserShouldSeeASuccessMessageConfirmingAvailabilityStatusChange()
        {
            string actualmessage = ProfileUserNameComponentObj .GetMessageBoxText();
            UserNameAssertionObj.AvailabilityAssertion("Availability updated", actualmessage);
        }

        [When(@"User able to update the desired Hours")]
        public void GivenUserAbleToUpdateTheDesiredHours()
        {
            UserNameStepsObj.AddHoursWeek();
        }

        [Then(@"User should see a success message confirming Hours status change")]
        public void WhenUserShouldSeeASuccessMessageConfirmingHoursStatusChange()
        {
            string actualmessage = ProfileUserNameComponentObj.GetMessageBoxText();
            UserNameAssertionObj.HoursAssertion("Availability updated", actualmessage);
        }

        [When(@"User able to update the desired Target")]
        public void GivenUserAbleToUpdateTheDesiredTarget()
        {
            UserNameStepsObj.AddEarnTarget();
        }

        [Then(@"User should see a success message confirming Target status change")]
        public void WhenUserShouldSeeASuccessMessageConfirmingTargetStatusChange()
        {
            string actualmessage = ProfileUserNameComponentObj.GetMessageBoxText();
            UserNameAssertionObj.EarnTargetAssertion("Availability updated", actualmessage);
        }

        [Then(@"User able to Edit the First and Last Name")]
        public void GivenUserAbleToEditTheFirstAndLastName()
        {
            UserNameStepsObj.addUserName();
        }
    }
}
