using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class LanguageSteps
    {
        [Given(@"seller is able to add new language")]
        public void GivenSellerIsAbleToAddNewLanguage()
        {
            //file name and Sheetname
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\Data.xlsx", "Language");
            LanguagePage.LAdd();
        }
        
        [Given(@"seller is able to update language")]
        public void GivenSellerIsAbleToUpdateLanguage()
        {
            LanguagePage.LUpdate();
        }
        
        [Given(@"seller is able to delete language")]
        public void GivenSellerIsAbleToDeleteLanguage()
        {
            LanguagePage.LDelete();
        }
    }
}
