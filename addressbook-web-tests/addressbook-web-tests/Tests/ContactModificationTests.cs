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
            int contactIndex = 0;
            if (!app.Contacts.AtLeastOneGroupCreated())
            {
                app.Contacts.Create(new ContactData("Initial-Fist", "Initial-Last"));
                app.Navigator.ReturnToHomePage();
                contactIndex = 0;
            }

            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            ContactData data = new ContactData("Modified-Fist", "Modified-Last");
 
            app.Contacts.Modify(contactIndex, data);
            List<ContactData> newContacts = app.Contacts.GetContactsList();

            oldContacts[contactIndex].FirstName = data.FirstName;
            oldContacts[contactIndex].LastName = data.LastName;
            oldContacts.Sort();
            newContacts.Sort();

            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
