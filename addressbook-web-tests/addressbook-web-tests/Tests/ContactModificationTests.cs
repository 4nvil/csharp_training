using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Contacts.Modify(1, new ContactData("Midified-Fist", "Modified-Last"));
            app.Navigator.ReturnToHomePage();
            app.Auth.Logout();
        }
    }
}
