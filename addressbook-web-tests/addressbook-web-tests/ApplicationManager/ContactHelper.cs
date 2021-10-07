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
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper Delete(int index)
        {
            SelectContact(index);
            DeleteContact();
            CloseAlert();           
            return this;
        }

        public bool AtLeastOneGroupCreated()
        {
            if (IsElementPresent(By.XPath("//tr[2]/td/input")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public ContactHelper Modify(int index, ContactData contactData)
        {
            OpenEditContactForm(index);
            FillContactForm(contactData);
            UpdateContact();
            return this;
        }
          public ContactHelper Create(ContactData contactData)
        {
            InitNewContactCreation();
            FillContactForm(contactData);
            SubmitContactCreation();
            return this;
        }

        public ContactHelper FillContactForm(ContactData contactData)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contactData.FirstName);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contactData.LastName);
            return this;
        }

        public ContactHelper InitNewContactCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public ContactHelper UpdateContact()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper OpenEditContactForm(int index)
        {
            index += 1;
            driver.FindElement(By.XPath("//tr[" + index + "]/td[8]/a/img")).Click();
            return this;
        }
        public ContactHelper SelectContact(int index)
        {
            index += 1;
            driver.FindElement(By.XPath("//tr[" + index + "]/td/input")).Click();
            return this;
        }
    }
}
