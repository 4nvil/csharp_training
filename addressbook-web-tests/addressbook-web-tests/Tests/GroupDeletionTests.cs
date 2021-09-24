﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupDeletionTests : TestBase
    {
        [Test]
        public void GroupDeletionTest()
        {
            app.Groups.Delete(1);
            app.Navigator.ReturnToGroupsPage();
            app.Auth.Logout();
        }
    }
}