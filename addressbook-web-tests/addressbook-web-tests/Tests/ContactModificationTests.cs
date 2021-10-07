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
            if (app.Contacts.AtLeastOneGroupCreated())
            {
                app.Contacts.Modify(1, new ContactData("Modified-Fist", "Modified-Last"));
                app.Navigator.ReturnToHomePage();
            }
            else
            {
                int index = 1;
                app.Contacts.Create(new ContactData("Created-Fist", "Created-Last"));
                app.Navigator.ReturnToHomePage();
                app.Contacts.Modify(index, new ContactData("Modified-Fist", "Modified-Last"));
            }
        }
    }
}
