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
            if (app.Contacts.AtLeastOneGroupCreated())
            {
                app.Contacts.Delete(1);
            }
            else
            {
                int index = 1;
                app.Contacts.Create(new ContactData("Created-Fist", "Created-Last"));
                app.Navigator.ReturnToHomePage();
                app.Contacts.Delete(index);
            }         
        }
    }
}
