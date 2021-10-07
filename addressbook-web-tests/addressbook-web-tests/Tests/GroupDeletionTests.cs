using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupDeletionTests : AuthTestBase
    {
        [Test]
        public void GroupDeletionTest()
        {
            app.Navigator.GoToGroupsPage();
            if (app.Groups.AtLeastOneGroupCreated())
            {
                app.Groups.Delete(1);
                app.Navigator.ReturnToGroupsPage();
            }
            else
            {
                int index = 1;
                GroupData newGroup = new GroupData("New Group Name");
                app.Groups.Create(newGroup);
                app.Navigator.ReturnToGroupsPage();
                app.Groups.Delete(index);
            }
        }
    }
}
