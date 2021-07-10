using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        [Given(@"seller has logged in successfully")]
        public void GivenSellerHasLoggedInSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"seller click on a pencil icon beside description")]
        public void GivenSellerClickOnAPencilIconBesideDescription()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"seller is able to write (.*) words in description text box")]
        public void GivenSellerIsAbleToWriteWordsInDescriptionTextBox(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"seller is able to edit (.*) or less words in description text box")]
        public void GivenSellerIsAbleToEditOrLessWordsInDescriptionTextBox(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"seller removes everything from  description text box")]
        public void GivenSellerRemovesEverythingFromDescriptionTextBox()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seller click on profile menu")]
        public void WhenSellerClickOnProfileMenu()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seller click on save button")]
        public void WhenSellerClickOnSaveButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"seller is able to see profile")]
        public void ThenSellerIsAbleToSeeProfile()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
