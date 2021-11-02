using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class ContactDeletionTests : AuthTestBase
    {
        [Test]
        public void ContactDeletionTest()
        {
            int contactIndex = 3;
            if (!app.Contacts.AtLeastOneGroupCreated())
            {
                ContactData data = new ContactData("Created-Fist", "Created-Last");
                app.Contacts.Create(data);
                app.Navigator.ReturnToHomePage();
                contactIndex = 1;
            }
            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            app.Contacts.Delete(contactIndex);
            List<ContactData> newContacts = app.Contacts.GetContactsList();
            oldContacts.RemoveAt(contactIndex - 1);
            
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
