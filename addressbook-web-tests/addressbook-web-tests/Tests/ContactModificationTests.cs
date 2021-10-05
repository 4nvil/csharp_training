using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Contacts.Modify(1, new ContactData("Modified-Fist", "Modified-Last"));
            app.Navigator.ReturnToHomePage();
        }
    }
}
