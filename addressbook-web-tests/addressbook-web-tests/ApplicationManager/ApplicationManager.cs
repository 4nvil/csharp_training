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
    public class ApplicationManager
    {
        private IWebDriver driver;
        private string baseURL;
        private LoginHelper loginHelper;
        private NavigationHelper navigator;
        private GroupHelper groupHelper;
        private ContactHelper contactHelper;

        public LoginHelper Auth { get => loginHelper; }
        public NavigationHelper Navigator { get => navigator; }
        public GroupHelper GroupHelper { get => groupHelper; }
        public ContactHelper ContactHelper { get => contactHelper; }
        public IWebDriver Driver { get => driver; }

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public void Stop()
        {
            try
            {
                Driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }        
        }
    }
}
