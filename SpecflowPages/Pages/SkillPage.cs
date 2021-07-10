using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace MarsQA_1.SpecflowPages.Pages
{
    public class SkillPage
    {

       
        private static IWebElement SkillTabClick => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        private static IWebElement AddNewSkillBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private static IWebElement SkillTextbox => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private static IWebElement SkillLevelDD => Driver.driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
        private static IWebElement AddSkillBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement CancelAddLanguageBtn => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//input[@value='Cancel']"));
        private static IWebElement SkillPencilIconBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        private static IWebElement UpdateSkillBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement CancelUpdateSkillBtn => Driver.driver.FindElement(By.XPath("//input[@value='Cancel']"));
        private static IWebElement SkillCrossIconBtn => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));


        public static void SAdd()
        {
            //wait for the page to load
            System.Threading.Thread.Sleep(5000);
            SkillTabClick.Click();
            //add all the rows from excel file
            AddNewSkillBtn.Click();
            SkillTextbox.SendKeys("English");
            SkillLevelDD.Click();
            Driver.driver.FindElement(By.XPath($"//option[@value='Beginner']")).Click();
            AddSkillBtn.Click();        
        }

        public static void SUpdate()
        {
            System.Threading.Thread.Sleep(5000);
            SkillPencilIconBtn.Click();
            SkillTextbox.Clear();
            SkillTextbox.SendKeys("updatedSkill");
            Driver.driver.FindElement(By.XPath($"//option[@value='Expert']")).Click();
            UpdateSkillBtn.Click();

            //FOR VALIDATION
            //IF(SKILLTEXTBOX == NULL)
            //    {
            //    ALERTHANDLING POPUPMSG = ALERTHANDLING.DRIVER.DRIVER.SWITCHTO().ALERT();
            //    CONSOLE.WRITELINE(POPUPMSG.GETTEXT())

            //}
            //|| (SKILLLEVEL.CLICK())
        }

        public static void SCancel()
        {
            System.Threading.Thread.Sleep(2000);
            SkillPencilIconBtn.Click();
            CancelUpdateSkillBtn.Click();
            Console.WriteLine("Updation Process Canceled");

        }

        public static void SDelete()
        {
            System.Threading.Thread.Sleep(1000);
           // if(SkillTextbox == "Dancing")
            SkillCrossIconBtn.Click();



        }
        //System.Threading.Thread.Sleep(5000);

        ////click on skills
        //IWebElement Skill = Driver.driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        //    Skill.Click();
        //    System.Threading.Thread.Sleep(5000);
        //    //click on add new
        //    IWebElement AddNew = Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']]"));
        //AddNew.Click();
        ////write skills in text box
        //IWebElement SkillTextBox = Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        //SkillTextBox.SendKeys("Cooking");  
        ////select level from dropdownlist
        ////IWebElement SkillLevelDropDown = Driver.Findelement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        //new SelectElement(Driver.driver.FindElement(By.XPath("//select[@name='level']")));
        ////click on Add
        //IWebElement Add = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));  
        //Add.Click();
        ////validate if skill is added to your list
        // }
    }
}