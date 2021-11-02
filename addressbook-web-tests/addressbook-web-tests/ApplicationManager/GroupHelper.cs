using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }
        
        public bool AtLeastOneGroupCreated()
        {
            if (IsElementPresent(By.XPath("//div[@id='content']/form/span[1]/input")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal List<GroupData> GetGroupsList()
        {
            List<GroupData> groupList = new List<GroupData>();
            manager.Navigator.GoToGroupsPage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
            
            foreach(IWebElement element in elements)
            {
                groupList.Add(new GroupData(element.Text));
            }
            return groupList;
        }

        public GroupHelper Create (GroupData group)
        {
           manager.Navigator.GoToGroupsPage();
           InitNewGroupCreation();
           FillGroupForm(group);
           Submit();
           return this;
        }

        public GroupHelper Modify(int index, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();              
            SelectGroup(index);
            EditGroup();
            FillGroupForm(newData);
            Update();
            return this;
        }
        
        public GroupHelper Delete(int index)
        {
            manager.Navigator.GoToGroupsPage();
            DeleteGroup(index);
            return this;
        }

        public GroupHelper Submit()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper Update()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Click();
            driver.FindElement(By.XPath("//form[@action='/addressbook/group.php']")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Click();
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Click();
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
        public GroupHelper DeleteGroup(int index)
        {
            if (IsElementPresent(By.XPath("//div[@id='content']/form/span[1]/input")))
            {
                SelectGroup(index);
                driver.FindElement(By.Name("delete")).Click();
            }
            else
            {
                index = 1;
                Create(new GroupData("Empty group"));
                DeleteGroup(index);
            }
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/span[" + (index + 1) + "]/input")).Click();
            return this;
        }
   
        public GroupHelper EditGroup()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }
    }
}
