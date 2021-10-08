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
            int contactIndex = 1;
            if (!app.Contacts.AtLeastOneGroupCreated())
            {
                app.Contacts.Create(new ContactData("Created-Fist", "Created-Last"));
                app.Navigator.ReturnToHomePage();
                contactIndex = 1;
            }           
            app.Contacts.Delete(contactIndex);
        }
    }
}
