﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    class ContactDeletionTests : TestBase
    {
        [Test]
        public void ContactDeletionTest()
        {
            app.Contacts.Delete(1);
            app.Auth.Logout();
        }
    }
}