using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("Group Name Test");
            group.Header = "Header Test";
            group.Footer = "Footer Test";
            app.GroupHelper.Create(group);         
            app.Navigator.ReturnToGroupsPage();
            app.Auth.Logout();
        }
    }
}