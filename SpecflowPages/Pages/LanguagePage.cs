using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class LanguagePage
    {
        private static IWebElement LanguageTabClick => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Languages']']"));
        private static IWebElement AddNewLanguageBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement LanguageTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement LanguageLevelDD => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private static IWebElement AddLanguageBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement CancelAddLanguageBtn => Driver.driver.FindElement(By.XPath("//div[@class='six wide field']//input[@value='Cancel']"));
        private static IWebElement EditLanguageBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[1]/i[1]"));
        private static IWebElement UpdateLanguageBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement CancelUpdateLanguageBtn => Driver.driver.FindElement(By.XPath("//span[@class='buttons-wrapper']//input[@value='Cancel']"));
        private static IWebElement DeleteLanguageBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[2]/tr[1]/td[3]/span[2]/i[1]"));

        public static void LAdd()
        {
            //wait for the page to load
            System.Threading.Thread.Sleep(7000); 
            // LanguageTabClick.Click();
            //add all the rows from excel file
            for (int i = 2; i <= ExcelLibHelper.rowcount; i++)
            {
                AddNewLanguageBtn.Click();
                //row number and column name                
                LanguageTextbox.SendKeys(ExcelLibHelper.ReadData(2, "Language"));
                LanguageLevelDD.Click();
                Driver.driver.FindElement(By.XPath($"//option[@value='Basic']")).Click();
                AddLanguageBtn.Click();
            }


        }    

        public static void LUpdate()
        {
            System.Threading.Thread.Sleep(2000);
            LanguageTabClick.Click();
            EditLanguageBtn.Click();
            LanguageTextbox.Clear();
            LanguageTextbox.SendKeys("updatedLanguage");
            Driver.driver.FindElement(By.XPath($"//option[@value='Fluent']")).Click();
            UpdateLanguageBtn.Click();

        }
        public static void LDelete()
        {
            System.Threading.Thread.Sleep(5000);
            LanguageTabClick.Click();
            DeleteLanguageBtn.Click();
        }
    }
}

