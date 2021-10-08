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
            int contactIndex = 1;
            if (!app.Contacts.AtLeastOneGroupCreated())
            {
                app.Contacts.Create(new ContactData("Initial-Fist", "Initial-Last"));
                app.Navigator.ReturnToHomePage();
                contactIndex = 1;
            }          
            app.Contacts.Modify(contactIndex, new ContactData("Modified-Fist", "Modified-Last"));
            app.Navigator.ReturnToHomePage();
        }
    }
}
