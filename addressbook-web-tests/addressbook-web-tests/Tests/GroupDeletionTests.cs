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
            int groupIndex = 1;
            app.Navigator.GoToGroupsPage();
            if (!app.Groups.AtLeastOneGroupCreated())
            {
                app.Groups.Create(new GroupData("New Group Name"));
                app.Navigator.ReturnToGroupsPage();
                groupIndex = 1;
            }           
            app.Groups.Delete(groupIndex);
            app.Navigator.ReturnToGroupsPage();         
        }
    }
}
