using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class EducationSteps
    {
        [Given(@"Seller clicks on certificate tab")]
        public void GivenSellerClicksOnCertificateTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seller wants to add certificate")]
        public void WhenSellerWantsToAddCertificate(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seller wants to update certificate")]
        public void WhenSellerWantsToUpdateCertificate(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"seller wants to delete certificate")]
        public void WhenSellerWantsToDeleteCertificate()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"seller clicks on Add button")]
        public void ThenSellerClicksOnAddButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"seller clicks on Update button")]
        public void ThenSellerClicksOnUpdateButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"seller clicks on cross icon button")]
        public void ThenSellerClicksOnCrossIconButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
