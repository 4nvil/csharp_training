using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void TheUntitledTestCaseTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitNewContactCreation();
            FillContactForm(new ContactData("Fist", "Last"));
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
        }
    }
}
