using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public LoginHelper Auth { get => loginHelper; }
        public NavigationHelper Navigator { get => navigator; }
        public GroupHelper Groups { get => groupHelper; }
        public ContactHelper Contacts { get => contactHelper; }
        public IWebDriver Driver { get => driver; }

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(this);
            navigator = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }
        public static ApplicationManager GetInstance()
        {
            if( ! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.Navigator.OpenHomePage();
                app.Value = newInstance;
            }  
            return app.Value;
        }
         ~ApplicationManager()
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
