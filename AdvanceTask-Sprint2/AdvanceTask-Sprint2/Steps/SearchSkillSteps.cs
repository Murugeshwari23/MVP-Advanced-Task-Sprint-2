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
    public class SearchSkillSteps  : BaseSetup
    {
        SearchSkillsComponent SearchSkillsComponentObj;
    //SearchSkillAssertions SearchSkillAssertionsObj;
    ProfileTabPageSteps ProfileTabPageStepsObj;

    public SearchSkillSteps()
    {
        ProfileTabPageStepsObj = new ProfileTabPageSteps();
        SearchSkillsComponentObj = new SearchSkillsComponent();
       // SearchSkillAssertionsObj = new SearchSkillAssertions();
    }

    public void SearchBySkill()
    {
        List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\SearchSkill.json");
        foreach (SearchSkillModel searchskill in SearchSkillModelList)
        {
            SearchSkillsComponentObj.SkillToBeSearched(searchskill);
        }
    }
    public void SearchByUserName()
    {
        List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\SearchByUserName.json");
        foreach (SearchSkillModel searchuserskill in SearchSkillModelList)
        {
            ProfileTabPageStepsObj.clickSearchSkillIcon();
            Thread.Sleep(4000);
            SearchSkillsComponentObj.SearchUser(searchuserskill);
        }
    }
    public void SearchByCategoryclicked()
    {
        List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\CategoryData.json");
        foreach (SearchSkillModel categoryData in SearchSkillModelList)
        {
            ProfileTabPageStepsObj.clickSearchSkillIcon();
            Thread.Sleep(4000);
           SearchSkillsComponentObj.SearchByCategory(categoryData);
            
        }
    }
    public void SearchByFilterclicked()
    {
        List<SearchSkillModel> SearchSkillModelList = JsonHelper.ReadTestDataFromJson<SearchSkillModel>("C:\\AdvnacedTask-Sprint-2\\MVP-Advanced-Task-Sprint-2\\AdvanceTask-Sprint2\\AdvanceTask-Sprint2\\JsonDataFiles\\FilterData.json");
        foreach (SearchSkillModel filterData in SearchSkillModelList)
        {
            ProfileTabPageStepsObj.clickSearchSkillIcon();
            Thread.Sleep(4000);
            SearchSkillsComponentObj.SearchByFilter(filterData);
         
        }
    }

}
}