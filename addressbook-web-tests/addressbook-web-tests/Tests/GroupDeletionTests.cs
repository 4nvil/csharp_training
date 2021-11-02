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
            int groupIndex = 0;
            app.Navigator.GoToGroupsPage();           
            
            if (!app.Groups.AtLeastOneGroupCreated())
            {
                GroupData data = new GroupData("New Group Name");
                app.Groups.Create(data);
                app.Navigator.ReturnToGroupsPage();
                groupIndex = 0;
            }

            List<GroupData> oldGroups = app.Groups.GetGroupsList();         
            app.Groups.Delete(groupIndex);      
            List<GroupData> newGroups = app.Groups.GetGroupsList();           
            oldGroups.RemoveAt(groupIndex);
            newGroups.Sort();
            oldGroups.Sort();
            Assert.AreEqual(newGroups, oldGroups);
        }
    }
}
