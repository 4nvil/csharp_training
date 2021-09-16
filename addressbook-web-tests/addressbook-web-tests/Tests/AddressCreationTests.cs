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
            app.ContactHelper
                .InitNewContactCreation()
                .FillContactForm(new ContactData("Fist", "Last"))
                .SubmitContactCreation();
            app.Navigator.ReturnToHomePage();
            app.Auth.Logout();
        }
    }
}
