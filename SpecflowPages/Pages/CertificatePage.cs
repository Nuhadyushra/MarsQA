using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class CertificatePage
    {
        private static IWebElement CertificateTabClick => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        private static IWebElement AddNewCertificateBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='ui teal button '][normalize-space()='Add New']"));
        private static IWebElement CertificateNameTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private static IWebElement CertificateFromTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement CertificateYearDD => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
        private static IWebElement AddCertificateBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement CancelAddCertificateBtn => Driver.driver.FindElement(By.XPath("//input[@value='Cancel']"));
        private static IWebElement EditCertificateBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private static IWebElement UpdateCertificateBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement CancelUpdateCertificateBtn => Driver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Cancel']"));
        private static IWebElement DeleteCertificateBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));


        public static void CAdd()
        {
            //wait for the page to load
            System.Threading.Thread.Sleep(7000);
            CertificateTabClick.Click();
            //add all the rows from excel file
            for (int i = 2; i <= ExcelLibHelper.rowcount; i++)
            {
                AddNewCertificateBtn.Click();
                //row number and column name                
                CertificateNameTextbox.SendKeys(ExcelLibHelper.ReadData(i, "CertificateName"));
                CertificateFromTextbox.SendKeys(ExcelLibHelper.ReadData(i, "CertificateFrom"));
                CertificateYearDD.Click();
                Driver.driver.FindElement(By.XPath($"//option[@value='2015']")).Click();
                AddCertificateBtn.Click();
            }


        }

        public static void CUpdate()
        {
            System.Threading.Thread.Sleep(5000);
            EditCertificateBtn.Click();
            CertificateNameTextbox.Clear();
            CertificateFromTextbox.Clear();
            CertificateNameTextbox.SendKeys("updatedCertificate");
            CertificateFromTextbox.SendKeys("updated");
            Driver.driver.FindElement(By.XPath($"//option[@value='2021']")).Click();
            UpdateCertificateBtn.Click();

        }
        public static void CDelete()
        {
            System.Threading.Thread.Sleep(5000);
            DeleteCertificateBtn.Click();
        }


    }
}
