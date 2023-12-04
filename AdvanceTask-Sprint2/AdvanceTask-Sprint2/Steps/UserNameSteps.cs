using AdvanceTask_Sprint2.TestModel;
using AdvanceTask_Sprint2.Utilities;
using AdvanceTask_Sprint2.Components.ProfilePageTabComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvanceTask_Sprint2.AssertHelpers;

namespace AdvanceTask_Sprint2.Steps
{
    public class UserNameSteps : BaseSetup
    {
        ProfileUserNameComponent ProfileUserNameComponentObj;
        ProfileTabPageSteps profileTabPageStepsObj;
        UserNameAssertion UserNameAssertionObj;

        public UserNameSteps()
        {
            ProfileUserNameComponentObj = new ProfileUserNameComponent();
            profileTabPageStepsObj = new ProfileTabPageSteps();
            UserNameAssertionObj = new UserNameAssertion();

        }
        public void addUserName()
        {

            List<UserNameModel> UserNameModelList = JsonHelper.ReadTestDataFromJson<UserNameModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\UserFirstLastName.json");
            foreach (UserNameModel username in UserNameModelList)
            {
                profileTabPageStepsObj.clickProfileUserNameButton();
                ProfileUserNameComponentObj.AddFirstLastName(username);
                UserNameAssertionObj.AssertFirstName(username);

            }
        }
        public void AddAvailabilityTime()
        {
            List<UserNameModel> AvailabilityModelList = JsonHelper.ReadTestDataFromJson<UserNameModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\Availability.json");
            foreach (UserNameModel availability in AvailabilityModelList)
            {
                profileTabPageStepsObj.clickAvailabilityTimePencilIcon();
                ProfileUserNameComponentObj.AddAvailability(availability);
                string actualmessage = ProfileUserNameComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
            }
        }
        public void AddHoursWeek()
        {
            List<UserNameModel> HoursModelList = JsonHelper.ReadTestDataFromJson<UserNameModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\AddHours.json");
            foreach (UserNameModel hours in HoursModelList)
            {
                profileTabPageStepsObj.clickHoursPenilIcon();
                ProfileUserNameComponentObj.AddHours(hours);
                string actualmessage = ProfileUserNameComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
            }
        }
        public void AddEarnTarget()
        {
            List<UserNameModel> TargetModelList = JsonHelper.ReadTestDataFromJson<UserNameModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\AddTarget.json");
            foreach (UserNameModel target in TargetModelList)
            {
                profileTabPageStepsObj.clickTargetPencilIcon();
                ProfileUserNameComponentObj.AddTarget(target);
                string actualmessage = ProfileUserNameComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
            }

        }
    }

}

