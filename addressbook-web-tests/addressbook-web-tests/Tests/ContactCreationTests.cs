using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {

            List<ContactData> oldContacts = app.Contacts.GetContactsList();
            ContactData contact = new ContactData("Fist", "Last");
            app.Contacts.Create(contact);
            app.Navigator.ReturnToHomePage();
            List<ContactData> newContacts = app.Contacts.GetContactsList();
            
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(newContacts, oldContacts);
        }
    }
}
