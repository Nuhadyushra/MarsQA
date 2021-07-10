using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"seller is able to Add new skill")]
        public void GivenSellerIsAbleToAddNewSkill()
        {
            SkillPage.SAdd();
        }
        
        [Given(@"seller is able to update skills")]
        public void GivenSellerIsAbleToUpdateSkills()
        {
            SkillPage.SUpdate();
        }
        
        [Given(@"seller is able to delete skills")]
        public void GivenSellerIsAbleToDeleteSkills()
        {
            SkillPage.SDelete();
        }
    }
}
