using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class CertificateSteps
    {
        [Given(@"Seller is able to Add new Certificate")]
        public void GivenSellerIsAbleToAddNewCertificate()
        {
            ExcelLibHelper.PopulateInCollection($@"{ConstantHelpers.path}\SpecflowTests\Data\Data.xlsx", "Certificate");
            CertificatePage.CAdd();
        }
        
        [Given(@"Seller is able to update certificate")]
        public void GivenSellerIsAbleToUpdateCertificate()
        {
            CertificatePage.CUpdate();
        }
        
        [Given(@"seller is able to delete certificate")]
        public void GivenSellerIsAbleToDeleteCertificate()
        {
            CertificatePage.CDelete();
        }
    }
}
