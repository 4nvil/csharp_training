﻿using System;
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
        public void ContactCreationTest()
        {
            app.Contacts.Create(new ContactData("Fist", "Last"));
            app.Navigator.ReturnToHomePage();
            app.Auth.Logout();
        }
    }
}