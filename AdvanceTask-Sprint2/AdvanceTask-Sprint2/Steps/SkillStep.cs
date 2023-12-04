using AdvanceTask_Sprint2.TestModel;
using AdvanceTask_Sprint2.Utilities;
using AdvanceTask_Sprint2.Components.ProfilePageTabComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTask_Sprint2.Steps
{
    public class SkillStep : BaseSetup
    {
        SkillComponent skillComponentObj;
        AddUpdateDeleteSkillComponent addUpdateDeleteSkillComponentObj;
      
        public SkillStep()
        {
            skillComponentObj = new SkillComponent();
            addUpdateDeleteSkillComponentObj = new AddUpdateDeleteSkillComponent();
        }
        public void AddSkill()
        { 
            List<SkillModel> SkillModellList = JsonHelper.ReadTestDataFromJson<SkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\AddSkill.json");
            foreach (SkillModel skilldata in SkillModellList)
            {
                skillComponentObj.clickAddSkill();
                addUpdateDeleteSkillComponentObj.AddSkills(skilldata);
                Thread.Sleep(2000);
                string actualmessage = addUpdateDeleteSkillComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
            }
        }
        public void UpdateSkill()
        {

            List<SkillModel> SkillModellList = JsonHelper.ReadTestDataFromJson<SkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\UpdateSkill.json");
            foreach (SkillModel skilldata in SkillModellList)
            {
                skillComponentObj.clickUpdateSkill();
                addUpdateDeleteSkillComponentObj.updateSkills(skilldata);
                string actualmessage = addUpdateDeleteSkillComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
            }
        }
        public void DeleteSkill()
        {
            List<SkillModel> SkillModellList = JsonHelper.ReadTestDataFromJson<SkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\DeleteSkill.json");
            foreach (SkillModel skilldata in SkillModellList)
            {
                addUpdateDeleteSkillComponentObj.deleteSkill(skilldata);
                string actualmessage = addUpdateDeleteSkillComponentObj.GetMessageBoxText();
                Console.WriteLine(actualmessage);
            }
        }
    }
}
